using CSGSI;
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

        string version = "v1.3.2";
        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        GameStateListener gsl = new GameStateListener(4123);
        DiscordRpcClient discordRPCClient;
        DateTime startTime;

        string userId = "";
        string friendCode = "";
        string apiEndpoint = "https://johnnyapi.herokuapp.com";


        public static class IdleSetting
        {
            public static bool ShowButton { get; set; }
            public static string Detail { get; set; } = "Idle";
            public static string State { get; set; } = "Chillin in the menu";

            public static string ButtonLabel { get; set; }
            public static string ButtonUrl { get; set;}
        }

        public static class IngameSetting
        {
            public static bool ShowTeam { get; set; }
            public static bool ShowMap { get; set; } = true;
            public static bool ShowButton { get; set; }

            public static string Detail { get; set; }
            public static string State { get; set; }
            public static string LargeText { get; set; }
            public static string SmallText { get; set; }

            public static string ButtonLabel { get; set; }
            public static string ButtonUrl { get; set; }
        }

        public Form1()
        {
            startTime = DateTime.UtcNow;
            discordRPCClient = new DiscordRpcClient(GetConfig("ApplicationId"), -1);
            InitializeComponent();
        }
        // =========================================================== Main Function ===========================================================
        private async void generateFriendCode(string id)
        {
            try
            {
                btnRefreshFriendCode.Enabled = false;
                string url = $"{apiEndpoint}/steam/steam-profile/{id}";
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
            // Debug Area
            tabDebug_lbLastActivity.Text = DateTime.Now.ToLongTimeString();
            label18.Text = gs.JSON;


            // Get Friendcode
            if (friendCode.Equals(""))
            {
                friendCode = "Generating...";
                generateFriendCode(gs.Provider.SteamID);
            }

            // Main GS Parse
            var player = gs.Player;
            var activity = player.Activity;

            if (activity.ToString().ToLower() == "menu")
            {
                var detail = ParsePlaceHolderIdle(gs, IdleSetting.Detail);
                var state = ParsePlaceHolderIdle(gs, IdleSetting.State);

                bool showButton = IdleSetting.ShowButton;
                string buttonLabel = ParsePlaceHolder(gs, IdleSetting.ButtonLabel);
                string buttonUrl = ParsePlaceHolder(gs, IdleSetting.ButtonUrl);

                UpdatePresence(detail, state, "csgo", "Playing CSGO", "csgo", "Playing CSGO", showButton, buttonLabel, buttonUrl);
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

                    bool showButton = IngameSetting.ShowButton;
                    string buttonLabel = ParsePlaceHolder(gs, IngameSetting.ButtonLabel);
                    string buttonUrl = ParsePlaceHolder(gs, IngameSetting.ButtonUrl);

                    if (IngameSetting.ShowMap) largeKey = $"{map}";
                    if (IngameSetting.ShowTeam) smallKey = player.Team.ToString() == "T" ? "terrorists" : "counterterrorists" ?? "spec";

                    UpdatePresence($"{detail}", $"{state}", largeKey, largeText, smallKey, smallText, showButton, buttonLabel, buttonUrl);
                }
                catch
                {

                }
            }
        }

        private void UpdatePresence(
            string title, string detail,
            string largeKey = "none", string largeText = "",
            string smallKey = "none", string smallText = "",
            bool showButton = false, string buttonLabel = "", string buttonUrl = "")
        {
            var buttons = new List<DiscordRPC.Button>();

            var button = new DiscordRPC.Button() { Label = buttonLabel, Url = buttonUrl};

            buttons.Add(button);

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
                Timestamps = new Timestamps(),
                Buttons = showButton == true ? buttons.ToArray() : null


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
            // Init ID

            txtApplicationId.Text = GetConfig("ApplicationId");
            // Init for Lobby
            IdleSetting.Detail = GetConfig("Lobby_Detail");
            IdleSetting.State = GetConfig("Lobby_State");
            IdleSetting.ShowButton = GetConfig("Lobby_ShowButton") == "True";
            IdleSetting.ButtonLabel = GetConfig("Lobby_ButtonLabel");
            IdleSetting.ButtonUrl = GetConfig("Lobby_ButtonUrl");

            tabLobby_txtDetail.Text = IdleSetting.Detail;
            tabLobby_txtState.Text = IdleSetting.State;
            tabLobby_cbShowButton.Checked = IdleSetting.ShowButton;
            tabLobby_txtButtonLabel.Text = IdleSetting.ButtonLabel;
            tabLobby_txtButtonUrl.Text = IdleSetting.ButtonUrl;

            // Init For Ingame
            IngameSetting.ShowMap = GetConfig("Ingame_ShowMap") == "True";
            IngameSetting.ShowTeam = GetConfig("Ingame_ShowTeam") == "True";
            IngameSetting.State = GetConfig("Ingame_State");
            IngameSetting.Detail = GetConfig("Ingame_Detail");
            IngameSetting.LargeText = GetConfig("Ingame_LargeText");
            IngameSetting.SmallText = GetConfig("Ingame_SmallText");

            IngameSetting.ShowButton = GetConfig("Ingame_ShowButton") == "True";
            IngameSetting.ButtonLabel = GetConfig("Ingame_ButtonLabel");
            IngameSetting.ButtonUrl = GetConfig("Ingame_ButtonUrl");

            tabIngame_cbShowMap.Checked = IngameSetting.ShowMap;
            tabIngame_cbShowTeam.Checked = IngameSetting.ShowTeam;
            tabIngame_txtState.Text = IngameSetting.State;
            tabIngame_txtDetail.Text = IngameSetting.Detail;
            tabIngame_txtLargeText.Text = IngameSetting.LargeText;
            tabIngame_txtSmallText.Text = IngameSetting.SmallText;

            tabIngame_cbShowButton.Checked = IngameSetting.ShowButton;
            tabIngame_txtButtonLabel.Text = IngameSetting.ButtonLabel;
            tabIngame_txtButtonUrl.Text = IngameSetting.ButtonUrl;

            lblVersion.Text = $"Version : {version.ToString()}";

            tabIngame_txtLargeText.Enabled = tabIngame_cbShowMap.Checked;
            tabIngame_txtSmallText.Enabled = tabIngame_cbShowTeam.Checked;
            tabIngame_txtButtonLabel.Enabled = tabIngame_cbShowButton.Checked;
            tabIngame_txtButtonUrl.Enabled = tabIngame_cbShowButton.Checked;

            tabLobby_txtButtonLabel.Enabled = tabLobby_cbShowButton.Checked;
            tabLobby_txtButtonUrl.Enabled = tabLobby_cbShowButton.Checked;

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
            bool showButton = tabLobby_cbShowButton.Checked;
            string buttonLabel = tabLobby_txtButtonLabel.Text;
            string buttonUrl = tabLobby_txtButtonUrl.Text;

            SetConfig("Lobby_Detail", detail);
            SetConfig("Lobby_State", state);
            SetConfig("Lobby_ShowButton", showButton == true ? "True" : "False");
            SetConfig("Lobby_ButtonLabel", buttonLabel);
            SetConfig("Lobby_ButtonUrl", buttonUrl);

            IdleSetting.Detail = detail;
            IdleSetting.State = state;
            IdleSetting.ShowButton = showButton;
            IdleSetting.ButtonLabel = buttonLabel;
            IdleSetting.ButtonUrl = buttonUrl;

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

            bool showButton = tabIngame_cbShowButton.Checked;
            string buttonLabel = tabIngame_txtButtonLabel.Text;
            string buttonUrl = tabIngame_txtButtonUrl.Text;

            SetConfig("Ingame_Detail", detail);
            SetConfig("Ingame_State", state);
            SetConfig("Ingame_ShowMap", ShowMap == true ? "True" : "False");
            SetConfig("Ingame_ShowTeam", ShowTeam == true ? "True" : "False");
            SetConfig("Ingame_LargeText", largeText);
            SetConfig("Ingame_SmallText", smallText);

            SetConfig("Ingame_ShowButton", showButton == true ? "True" : "False");
            SetConfig("Ingame_ButtonLabel", buttonLabel);
            SetConfig("Ingame_ButtonUrl", buttonUrl);

            IngameSetting.Detail = detail;
            IngameSetting.State = state;
            IngameSetting.ShowMap = ShowMap;
            IngameSetting.ShowTeam = ShowTeam;
            IngameSetting.LargeText = largeText;
            IngameSetting.SmallText = smallText;
            IngameSetting.ShowButton = showButton;
            IngameSetting.ButtonLabel = buttonLabel;
            IngameSetting.ButtonUrl = buttonUrl;

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

        private void tabLobby_cbShowButton_CheckedChanged(object sender, EventArgs e)
        {
            tabLobby_txtButtonLabel.Enabled = tabLobby_cbShowButton.Checked;
            tabLobby_txtButtonUrl.Enabled = tabLobby_cbShowButton.Checked;
        }

        private void tabIngame_cbShowButton_CheckedChanged(object sender, EventArgs e)
        {
            tabIngame_txtButtonLabel.Enabled = tabIngame_cbShowButton.Checked;
            tabIngame_txtButtonUrl.Enabled = tabIngame_cbShowButton.Checked;
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
            //generateFriendCode(userId);
            userId = "";
            friendCode = "";
            btnRefreshFriendCode.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmExit();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow();
        }


        private void tabDebug_btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            // JsonConvert.SerializeObject(gs.JSON, Formatting.Indented)
            Clipboard.SetText(label18.Text);
        }

        private void btnChangeId_Click(object sender, EventArgs e)
        {
            if (txtApplicationId.Text.Trim() != "")
            {
                SetConfig("ApplicationId", txtApplicationId.Text);
                discordRPCClient.ClearPresence();
                discordRPCClient = new DiscordRpcClient(txtApplicationId.Text, -1);
                MessageBox.Show("New Application ID Set. If it didn't update on discord, try restarting the application.");
            }
        }
    }
}
