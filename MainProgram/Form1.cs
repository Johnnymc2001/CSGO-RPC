using CSGSI;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Configuration = System.Configuration.Configuration;

namespace MainProgram
{
    public partial class Form1 : Form
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        GameStateListener gsl = new GameStateListener(4123);
        DiscordRpcClient client = new DiscordRpcClient("494378226857279498", -1);

        public static class IdleSetting
        {
            public static string Detail { get; set; } = "Idle";
            public static string State { get; set; } = "Chillin in the menu";
        }

        public static class IngameSetting
        {
            public static bool ShowMap { get; set; } = true;
            public static bool ShowGamemode { get; set; } = true;
            public static bool ShowKDA { get; set; } = true;
            public static string State { get; internal set; }
        }

        public Form1()
        {
            InitializeComponent();
        }
        // =========================================================== Main Function ===========================================================

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
                //client.Invoke();
                client.Initialize();
                gsl.NewGameState += OnNewGameState;
                gsl.Start();

                btnStart.Enabled = false;
            }
            catch (Exception ex)
            {
                DeInitService();

                btnStart.Enabled = true;
                MessageBox.Show("Failed to run, please try again!", ex.Message);

            }
        }

        private void DeInitService()
        {
            if (client.IsInitialized)
            {
                client.Deinitialize();
            }

            if (!client.IsDisposed)
            {
                client.Dispose();
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

            string phase = gs.Round.Phase.ToString();

            var t = game.TeamT;
            var ct = game.TeamCT;

            if (str == null) return "";

            str = str.Replace("{TScore}", t.Score.ToString())
                .Replace("{TName}", t.Name.ToString())

                .Replace("{CTScore}", ct.Score.ToString())
                .Replace("{CTName}", ct.Name.ToString())

                .Replace("{Phase}", phase)
                .Replace("{Round}", game.Round.ToString());

            return str;
        }

        private void OnNewGameState(GameState gs)
        {
            var player = gs.Player;
            var activity = player.Activity;

            if (activity.ToString().ToLower() == "menu")
            {
                var name = player.Name;
                var id = player.SteamID;

                IdleSetting.Detail = IdleSetting.Detail.Replace("{USERNAME}", name).Replace("{ID}", id);
                IdleSetting.State = IdleSetting.State.Replace("{USERNAME}", name).Replace("{ID}", id);

                UpdatePresence(IdleSetting.Detail, IdleSetting.State, "csgo", "Playing CSGO", "csgo", "Playing CSGO");
            }
            else if (activity.ToString().ToLower() == "playing")
            {
                var game = gs.Map;

                string map = game.Name;
                string mode = game.Mode.ToString();
                string phase = gs.Round.Phase.ToString();

                var teamT = game.TeamT;
                var teamCT = game.TeamCT;

                string detail = "";
                string largeKey = "";

                if (IngameSetting.ShowGamemode) detail += mode;
                if (IngameSetting.ShowMap) { detail += detail != "" ? " - " + map : map; largeKey = $"{map}"; }

                string stateStr = ParsePlaceHolder(gs, IngameSetting.State);
                Trace.WriteLine("Before : " + IngameSetting.State);
                Trace.WriteLine("After : " + stateStr);

                var stat = player.MatchStats;

                string smallKey = player.Team.ToString() == "T" ? "terrorists" : "counterterrorists" ?? "spec";
                string smallText = $"{player.Name}";

                if (IngameSetting.ShowKDA) smallText += $" | {stat.Kills}/{stat.Deaths}/{stat.Assists} ({stat.Score}) [{stat.MVPs}⭐]";


                UpdatePresence($"{detail}", $"{stateStr}", largeKey, largeKey, smallKey, smallText);
            }
            //Trace.Write(gs.JSON);
        }

        private void UpdatePresence(
            string title, string detail,
            string largeKey = "none", string largeText = "",
            string smallKey = "none", string smallText = "")
        {
            var curPres = client.CurrentPresence;
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
                }
            };

            if (curPres != null)
            {
                if (curPres != pres)
                {
                    client.SetPresence(pres);
                }
            }
            else
            {
                client.SetPresence(pres);
            }

        }

        // =========================================================== Main Form Events ===========================================================

        private void btnStart_Click(object sender, EventArgs e)
        {
            InitService();
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

        private void cbAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoStart.Checked)
            {
                SetConfig("AutoStart", "True");
            }
            else
            {
                SetConfig("AutoStart", "False");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Init for Lobby
            IdleSetting.Detail = GetConfig("Lobby_Detail");
            IdleSetting.State = GetConfig("Lobby_State");

            tabLobby_txtDetail.Text = IdleSetting.Detail;
            tabLobby_txtState.Text = IdleSetting.State;

            // Init For Ingame
            IngameSetting.ShowMap = GetConfig("Ingame_ShowMap") == "True";
            IngameSetting.ShowGamemode = GetConfig("Ingame_ShowGamemode") == "True";
            IngameSetting.ShowKDA = GetConfig("Ingame_ShowKDA") == "True";
            IngameSetting.State = GetConfig("Ingame_State");

            tabIngame_cbShowMap.Checked = IngameSetting.ShowMap;
            tabIngame_cbShowGamemode.Checked = IngameSetting.ShowGamemode;
            tabIngame_cbShowKDA.Checked = IngameSetting.ShowKDA;
            tabIngame_txtState.Text = IngameSetting.State;

            if (GetConfig("AutoStart") == "True")
            {
                // Init For Main
                cbAutoStart.Checked = true;
                InitService();
            }
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
        ""allplayers_id"" ""1"" 
        ""allplayers_state"" ""1"" 
        ""allplayers_match_stats"" ""1"" 
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

            MessageBox.Show("Setting saved!");
        }

        private void tabIngame_btnSave_Click(object sender, EventArgs e)
        {
            string state = tabIngame_txtState.Text;
            bool ShowMap = tabIngame_cbShowMap.Checked ? true : false;
            bool ShowGamemode = tabIngame_cbShowGamemode.Checked ? true : false;
            bool ShowKDA = tabIngame_cbShowKDA.Checked ? true : false;


            SetConfig("Ingame_State", state);
            SetConfig("Ingame_ShowMap", ShowMap == true ? "True" : "False");
            SetConfig("Ingame_ShowGamemode", ShowGamemode == true ? "True" : "False");
            SetConfig("Ingame_ShowKDA", ShowKDA == true ? "True" : "False");

            IngameSetting.State = state;
            IngameSetting.ShowMap = ShowMap;
            IngameSetting.ShowGamemode = ShowGamemode;
            IngameSetting.ShowKDA = ShowKDA;

            MessageBox.Show("Setting saved!");
        }
    }
}
