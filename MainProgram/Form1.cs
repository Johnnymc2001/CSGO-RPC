﻿using CSGSI;
using CSGSI.Nodes;
using DiscordRPC;
using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configuration = System.Configuration.Configuration;
using Flurl;
using Flurl.Http;
using Octokit;
using Application = System.Windows.Forms.Application;

namespace MainProgram
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        string version = "v1.2.2";
        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        GameStateListener gsl = new GameStateListener(4123);
        DiscordRpcClient discordRPCClient = new DiscordRpcClient("494378226857279498", -1);
        DateTime startTime;

        string userId = "";
        string friendCode = "";
        string apiEndpoint = "https://johnnyapi.herokuapp.com";


        public static class IdleSetting
        {
            public static string Detail { get; set; } = "Idle";
            public static string State { get; set; } = "Chillin in the menu";
        }

        public static class IngameSetting
        {
            public static bool ShowTeam { get; set; }
            public static bool ShowMap { get; set; } = true;

            public static string Detail { get; set; }
            public static string State { get; set; }
            public static string LargeText { get; set; }
            public static string SmallText { get; set; }
        }

        public Form1()
        {
            startTime = DateTime.UtcNow;
            InitializeComponent();
        }
        // =========================================================== Main Function ===========================================================
        private async void generateFriendCode(string id)
        {
            try
            {
                btnRefreshFriendCode.Enabled = false;
                string url = $"{apiEndpoint}/steam/id-to-friendcode/{id}";
                userId = id;
                UserInfoDTO fc = await url.GetJsonAsync<UserInfoDTO>();
                friendCode = fc.friendcode;
                txtFriendCode.Text = friendCode;
            }
            catch
            {

            }
            finally
            {
                btnRefreshFriendCode.Enabled = true;
            }
        }

        private async void getLastestVersion()
        {
            try
            {
                GitHubClient client = new GitHubClient(new ProductHeaderValue("Chrome"));
                var releases = await client.Repository.GetAllTags("Johnnymc2001", "CSGO-RPC");
                string tagName = releases[0].Name;
                if (tagName.Equals(version)) lblLastest.ForeColor = Color.Green;
                else lblLastest.ForeColor = Color.Red;

                lblLastest.Text = $"Lastest : {tagName}";
            }
            catch { lblLastest.Text = $"Lastest : Can't get :P"; }
        }

        private void SetConfig(string key, string value)
        {
            RemoveConfig(key);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Minimal);
        }

        private string GetConfig(string key)
        {
            return config.AppSettings.Settings[key]?.Value;
        }

        private void RemoveConfig(string key)
        {
            if (GetConfig(key) != null)
                config.AppSettings.Settings.Remove(key);
        }

        private void InitService()
        {
            try
            {
                discordRPCClient.Initialize();
                gsl.NewGameState += OnNewGameState;
                gsl.Start();

            }
            catch (Exception ex)
            {
                DeInitService();
                MessageBox.Show("Failed to run, please try again!", ex.Message);
                Environment.Exit(0);

            }
        }

        private void DeInitService()
        {
            if (discordRPCClient.IsInitialized)
            {
                discordRPCClient.Deinitialize();
            }

            if (!discordRPCClient.IsDisposed)
            {
                discordRPCClient.Dispose();
            }

            if (gsl.Running)
            {
                gsl.Stop();
            }
        }
        // ================================================================ GameStates ================================================================

        private string ParsePlaceHolder(GameState gs, string str)
        {
            var game = gs.Map;
            var player = gs.Player;
            var stat = player.MatchStats;

            string phase = gs.Map.Phase.ToString() == "Warmup" ? "Warmup" : gs.Round.Phase.ToString();

            var t = game.TeamT;
            var ct = game.TeamCT;

            if (str == null) return "";

            str = str
                .Replace("{TScore}", t.Score.ToString() ?? "")
                .Replace("{TName}", t.Name?.ToString() ?? "")

                .Replace("{CTScore}", ct.Score.ToString() ?? "")
                .Replace("{CTName}", ct.Name?.ToString() ?? "")

                .Replace("{Phase}", phase ?? "Warmup")
                .Replace("{Round}", (game.Round + 1).ToString() ?? "")
                .Replace("{Map}", game.Name?.ToString() ?? "")
                .Replace("{Mode}", game.Mode.ToString() ?? "")

                .Replace("{Name}", player.Name)
                .Replace("{Team}", player.Team.ToString() ?? "")
                .Replace("{Kill}", stat.Kills.ToString() ?? "")
                .Replace("{Death}", stat.Deaths.ToString() ?? "")
                .Replace("{Assist}", stat.Assists.ToString() ?? "")
                .Replace("{Score}", stat.Score.ToString() ?? "")
                .Replace("{MVP}", stat.MVPs.ToString() ?? "")

                .Replace("{ID}", player.SteamID.ToString())
                .Replace("{Version}", gs.Provider.Version.ToString())
                .Replace("{ProgramVersion}", version)
                .Replace("{FriendCode}", friendCode);

            return str;
        }

        private string ParsePlaceHolderIdle(GameState gs, string str)
        {
            var player = gs.Player;

            var name = player.Name;
            var id = player.SteamID;

            if (str == null) return "";

            str = str
                .Replace("{Username}", name)
                .Replace("{ID}", id)
                .Replace("{FriendCode}", friendCode);

            return str;
        }

        private void OnNewGameState(GameState gs)
        {
            if (friendCode.Equals(""))
            {
                friendCode = "Generating...";
                generateFriendCode(gs.Player.SteamID);
            }

            var player = gs.Player;
            var activity = player.Activity;

            if (activity.ToString().ToLower() == "menu")
            {
                var detail = ParsePlaceHolderIdle(gs, IdleSetting.Detail);
                var state = ParsePlaceHolderIdle(gs, IdleSetting.State);

                UpdatePresence(detail, state, "csgo", "Playing CSGO", "csgo", "Playing CSGO");
            }
            else if (activity.ToString().ToLower() == "playing")
            {
                try
                {
                    var game = gs.Map;


                    var stat = player.MatchStats;

                    string map = game?.Name ?? "";
                    string largeKey = "";
                    string smallKey = "";

                    string detail = ParsePlaceHolder(gs, IngameSetting.Detail);
                    string state = ParsePlaceHolder(gs, IngameSetting.State);
                    string largeText = ParsePlaceHolder(gs, IngameSetting.LargeText);
                    string smallText = ParsePlaceHolder(gs, IngameSetting.SmallText);

                    if (IngameSetting.ShowMap) largeKey = $"{map}";
                    if (IngameSetting.ShowTeam) smallKey = player.Team.ToString() == "T" ? "terrorists" : "counterterrorists" ?? "spec";

                    UpdatePresence($"{detail}", $"{state}", largeKey, largeText, smallKey, smallText);
                }
                catch
                {

                }
            }
        }

        private void UpdatePresence(
            string title, string detail,
            string largeKey = "none", string largeText = "",
            string smallKey = "none", string smallText = "")
        {
            var curPres = discordRPCClient.CurrentPresence;
            var pres = new RichPresence()
            {
                Details = title,
                State = detail,
                Assets = new Assets()
                {
                    LargeImageKey = largeKey,
                    LargeImageText = largeText,
                    SmallImageKey = smallKey,
                    SmallImageText = smallText,

                },
                Timestamps = new Timestamps()


            };

            if (curPres != null)
            {
                if (curPres != pres)
                {
                    discordRPCClient.SetPresence(pres);
                }
            }
            else
            {
                discordRPCClient.SetPresence(pres);
            }

        }

        // =========================================================== Main Form Events ===========================================================

        private void ConfirmExit()
        {
            DialogResult f = MessageBox.Show("Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (f == DialogResult.Yes)
            {
                DeInitService();
                Environment.Exit(0);
            }
        }

        private void ShowWindow()
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void HideWindow()
        {
            Hide();
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing)
                return;

            DialogResult f;
            f = MessageBox.Show("Are you sure you want to exit?", "CSGO - Discord Rich Presence", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (f == DialogResult.OK)
            {
                DeInitService();
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getLastestVersion();

            // Init for Lobby
            IdleSetting.Detail = GetConfig("Lobby_Detail");
            IdleSetting.State = GetConfig("Lobby_State");

            tabLobby_txtDetail.Text = IdleSetting.Detail;
            tabLobby_txtState.Text = IdleSetting.State;

            // Init For Ingame
            IngameSetting.ShowMap = GetConfig("Ingame_ShowMap") == "True";
            IngameSetting.ShowTeam = GetConfig("Ingame_ShowTeam") == "True";
            IngameSetting.State = GetConfig("Ingame_State");
            IngameSetting.Detail = GetConfig("Ingame_Detail");
            IngameSetting.LargeText = GetConfig("Ingame_LargeText");
            IngameSetting.SmallText = GetConfig("Ingame_SmallText");

            tabIngame_cbShowMap.Checked = IngameSetting.ShowMap;
            tabIngame_cbShowTeam.Checked = IngameSetting.ShowTeam;
            tabIngame_txtState.Text = IngameSetting.State;
            tabIngame_txtDetail.Text = IngameSetting.Detail;
            tabIngame_txtLargeText.Text = IngameSetting.LargeText;
            tabIngame_txtSmallText.Text = IngameSetting.SmallText;

            lblVersion.Text = $"Version : {version.ToString()}";
            InitService();
        }

        // ================================================================ Tab CSGO ================================================================

        private void tabCSGO_btnInstall_Click(object sender, EventArgs e)
        {
            object steamReg = Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Valve\Steam", "InstallPath", new object()) ?? Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Valve\Steam", "InstallPath", new object());

            var pathToLibraryFile = $@"{steamReg}\steamapps\libraryfolders.vdf";
            var cfgFolder = "";
            bool found = false;

            if (File.Exists(pathToLibraryFile))
            {
                string[] lines = File.ReadAllLines(pathToLibraryFile);

                foreach (string line in lines)
                {
                    if (line.Contains(@"path"))
                    {
                        cfgFolder = line.Replace("\"", "").Replace("path", "").Replace("\\\\", "\\").Trim();
                    }
                    else if (line.Contains("\"730\""))
                    {
                        found = true;
                        cfgFolder += @"\steamapps\common\Counter-Strike Global Offensive\csgo\cfg";
                        break;
                    }
                }

                if (found)
                {
                    if (File.Exists($@"{cfgFolder}\gamestate_integration_jrpc.cfg"))
                    {
                        MessageBox.Show("The program have already been installed!", "CSGO - Discord Rich Presence");
                    }
                    else
                    {
                        string cfg = @"""CSGSI"" 
{ 
""uri"" ""http://localhost:4123"" 
""timeout"" ""5.0"" 
""buffer"" ""0.1""
""heartbeat"" ""15.0""
""data"" 
    { 
        ""provider"" ""1"" 
        ""map"" ""1"" 
        ""round"" ""1"" 
        ""player_id"" ""1"" 
        ""player_weapons"" ""1"" 
        ""player_match_stats"" ""1"" 
        ""player_state"" ""1"" 
    } 
}";

                        File.WriteAllText($@"{cfgFolder}\gamestate_integration_jrpc.cfg", cfg);
                        MessageBox.Show("The program installed sucessfully!", "CSGO - Discord Rich Presence");
                    }
                }
                else
                {
                    MessageBox.Show("Auto-Install Failed. You can follow the steps in the readme to do it manually!", "CSGO - Discord Rich Presence");
                }
            }
        }

        // ================================================================ Tab Lobby ================================================================
        private void tabLobby_btnSave_Click(object sender, EventArgs e)
        {
            string detail = tabLobby_txtDetail.Text;
            string state = tabLobby_txtState.Text;

            SetConfig("Lobby_Detail", detail);
            SetConfig("Lobby_State", state);

            IdleSetting.Detail = detail;
            IdleSetting.State = state;

            MessageBox.Show("Setting successfulyl saved!", "Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabIngame_btnSave_Click(object sender, EventArgs e)
        {
            string detail = tabIngame_txtDetail.Text;
            string state = tabIngame_txtState.Text;
            string largeText = tabIngame_txtLargeText.Text;
            string smallText = tabIngame_txtSmallText.Text;
            bool ShowMap = tabIngame_cbShowMap.Checked ? true : false;
            bool ShowTeam = tabIngame_cbShowTeam.Checked ? true : false;


            SetConfig("Ingame_Detail", detail);
            SetConfig("Ingame_State", state);
            SetConfig("Ingame_ShowMap", ShowMap == true ? "True" : "False");
            SetConfig("Ingame_ShowTeam", ShowTeam == true ? "True" : "False");
            SetConfig("Ingame_LargeText", largeText);
            SetConfig("Ingame_SmallText", smallText);

            IngameSetting.Detail = detail;
            IngameSetting.State = state;
            IngameSetting.ShowMap = ShowMap;
            IngameSetting.ShowTeam = ShowTeam;
            IngameSetting.LargeText = largeText;
            IngameSetting.SmallText = smallText;

            MessageBox.Show("Setting successfulyl saved!", "Config", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabIngame_cbShowMap_CheckedChanged(object sender, EventArgs e)
        {
            tabIngame_txtLargeText.Enabled = tabIngame_cbShowMap.Checked;
        }

        private void tabIngame_cbShowTeam_CheckedChanged(object sender, EventArgs e)
        {
            tabIngame_txtSmallText.Enabled = tabIngame_cbShowTeam.Checked;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            HideWindow();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowWindow();
        }

        private void btnRefreshFriendCode_Click(object sender, EventArgs e)
        {
            generateFriendCode(userId);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }
    }
}
