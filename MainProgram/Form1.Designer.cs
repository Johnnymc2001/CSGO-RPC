namespace MainProgram
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tabCSGO_btnInstall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabLobby_btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLobby_txtState = new System.Windows.Forms.TextBox();
            this.tabLobby_txtDetail = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tabIngame_txtLargeText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabIngame_txtSmallText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabIngame_txtDetail = new System.Windows.Forms.TextBox();
            this.tabIngame_cbShowTeam = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabIngame_txtState = new System.Windows.Forms.TextBox();
            this.tabIngame_btnSave = new System.Windows.Forms.Button();
            this.tabIngame_cbShowMap = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txtFriendCode = new System.Windows.Forms.TextBox();
            this.btnRefreshFriendCode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(11, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 262);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.btnRefreshFriendCode);
            this.tabPage1.Controls.Add(this.txtFriendCode);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.lblVersion);
            this.tabPage1.Controls.Add(this.tabCSGO_btnInstall);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(362, 30);
            this.label8.TabIndex = 8;
            this.label8.Text = "This program must be running for the presence to work!\r\nYou can minimize it if yo" +
    "u like";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(7, 215);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(51, 13);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Version : ";
            // 
            // tabCSGO_btnInstall
            // 
            this.tabCSGO_btnInstall.Location = new System.Drawing.Point(409, 6);
            this.tabCSGO_btnInstall.Name = "tabCSGO_btnInstall";
            this.tabCSGO_btnInstall.Size = new System.Drawing.Size(75, 23);
            this.tabCSGO_btnInstall.TabIndex = 6;
            this.tabCSGO_btnInstall.Text = "Install";
            this.tabCSGO_btnInstall.UseVisualStyleBackColor = true;
            this.tabCSGO_btnInstall.Click += new System.EventHandler(this.tabCSGO_btnInstall_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(346, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "This program require custom Gamestate Intergration CFG File.\r\nClick Install to co" +
    "py the Gamestate Intergration CFG\r\nThe program use Port 4123 ";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.tabLobby_btnSave);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tabLobby_txtState);
            this.tabPage2.Controls.Add(this.tabLobby_txtDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lobby";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabLobby_btnSave
            // 
            this.tabLobby_btnSave.Location = new System.Drawing.Point(409, 195);
            this.tabLobby_btnSave.Name = "tabLobby_btnSave";
            this.tabLobby_btnSave.Size = new System.Drawing.Size(75, 23);
            this.tabLobby_btnSave.TabIndex = 12;
            this.tabLobby_btnSave.Text = "Save";
            this.tabLobby_btnSave.UseVisualStyleBackColor = true;
            this.tabLobby_btnSave.Click += new System.EventHandler(this.tabLobby_btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "When your are not in a match";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details";
            // 
            // tabLobby_txtState
            // 
            this.tabLobby_txtState.Location = new System.Drawing.Point(77, 59);
            this.tabLobby_txtState.Name = "tabLobby_txtState";
            this.tabLobby_txtState.Size = new System.Drawing.Size(407, 20);
            this.tabLobby_txtState.TabIndex = 1;
            // 
            // tabLobby_txtDetail
            // 
            this.tabLobby_txtDetail.Location = new System.Drawing.Point(77, 30);
            this.tabLobby_txtDetail.Name = "tabLobby_txtDetail";
            this.tabLobby_txtDetail.Size = new System.Drawing.Size(407, 20);
            this.tabLobby_txtDetail.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tabIngame_txtLargeText);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.tabIngame_txtSmallText);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tabIngame_txtDetail);
            this.tabPage3.Controls.Add(this.tabIngame_cbShowTeam);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tabIngame_txtState);
            this.tabPage3.Controls.Add(this.tabIngame_btnSave);
            this.tabPage3.Controls.Add(this.tabIngame_cbShowMap);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(490, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ingame";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Large Image Text";
            // 
            // tabIngame_txtLargeText
            // 
            this.tabIngame_txtLargeText.Location = new System.Drawing.Point(102, 99);
            this.tabIngame_txtLargeText.Name = "tabIngame_txtLargeText";
            this.tabIngame_txtLargeText.Size = new System.Drawing.Size(385, 20);
            this.tabIngame_txtLargeText.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Small Image Text";
            // 
            // tabIngame_txtSmallText
            // 
            this.tabIngame_txtSmallText.Location = new System.Drawing.Point(101, 147);
            this.tabIngame_txtSmallText.Name = "tabIngame_txtSmallText";
            this.tabIngame_txtSmallText.Size = new System.Drawing.Size(385, 20);
            this.tabIngame_txtSmallText.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Detail";
            // 
            // tabIngame_txtDetail
            // 
            this.tabIngame_txtDetail.Location = new System.Drawing.Point(101, 26);
            this.tabIngame_txtDetail.Name = "tabIngame_txtDetail";
            this.tabIngame_txtDetail.Size = new System.Drawing.Size(386, 20);
            this.tabIngame_txtDetail.TabIndex = 22;
            // 
            // tabIngame_cbShowTeam
            // 
            this.tabIngame_cbShowTeam.AutoSize = true;
            this.tabIngame_cbShowTeam.Location = new System.Drawing.Point(9, 132);
            this.tabIngame_cbShowTeam.Name = "tabIngame_cbShowTeam";
            this.tabIngame_cbShowTeam.Size = new System.Drawing.Size(83, 17);
            this.tabIngame_cbShowTeam.TabIndex = 21;
            this.tabIngame_cbShowTeam.Text = "Show Team";
            this.tabIngame_cbShowTeam.UseVisualStyleBackColor = true;
            this.tabIngame_cbShowTeam.CheckedChanged += new System.EventHandler(this.tabIngame_cbShowTeam_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "State";
            // 
            // tabIngame_txtState
            // 
            this.tabIngame_txtState.Location = new System.Drawing.Point(101, 52);
            this.tabIngame_txtState.Name = "tabIngame_txtState";
            this.tabIngame_txtState.Size = new System.Drawing.Size(386, 20);
            this.tabIngame_txtState.TabIndex = 18;
            // 
            // tabIngame_btnSave
            // 
            this.tabIngame_btnSave.Location = new System.Drawing.Point(412, 198);
            this.tabIngame_btnSave.Name = "tabIngame_btnSave";
            this.tabIngame_btnSave.Size = new System.Drawing.Size(75, 23);
            this.tabIngame_btnSave.TabIndex = 15;
            this.tabIngame_btnSave.Text = "Save";
            this.tabIngame_btnSave.UseVisualStyleBackColor = true;
            this.tabIngame_btnSave.Click += new System.EventHandler(this.tabIngame_btnSave_Click);
            // 
            // tabIngame_cbShowMap
            // 
            this.tabIngame_cbShowMap.AutoSize = true;
            this.tabIngame_cbShowMap.Location = new System.Drawing.Point(9, 82);
            this.tabIngame_cbShowMap.Name = "tabIngame_cbShowMap";
            this.tabIngame_cbShowMap.Size = new System.Drawing.Size(109, 17);
            this.tabIngame_cbShowMap.TabIndex = 13;
            this.tabIngame_cbShowMap.Text = "Show Map Image";
            this.tabIngame_cbShowMap.UseVisualStyleBackColor = true;
            this.tabIngame_cbShowMap.CheckedChanged += new System.EventHandler(this.tabIngame_cbShowMap_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "When your are in a match";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "The program has been minimized to tray";
            this.notifyIcon.BalloonTipTitle = "CSGO - Discord Rich Presence";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "CSGO - Discord Rich Presence";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 35);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "CSGO - Discord Rich Presence";
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainProgram.Properties.Resources.csgo_icon_42849;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.MistyRose;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Location = new System.Drawing.Point(441, 5);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(29, 24);
            this.btn_Minimize.TabIndex = 8;
            this.btn_Minimize.Text = "——";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Red;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Location = new System.Drawing.Point(476, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(29, 24);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "X";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txtFriendCode
            // 
            this.txtFriendCode.Location = new System.Drawing.Point(331, 208);
            this.txtFriendCode.Name = "txtFriendCode";
            this.txtFriendCode.Size = new System.Drawing.Size(89, 20);
            this.txtFriendCode.TabIndex = 9;
            // 
            // btnRefreshFriendCode
            // 
            this.btnRefreshFriendCode.Location = new System.Drawing.Point(425, 206);
            this.btnRefreshFriendCode.Name = "btnRefreshFriendCode";
            this.btnRefreshFriendCode.Size = new System.Drawing.Size(57, 22);
            this.btnRefreshFriendCode.TabIndex = 10;
            this.btnRefreshFriendCode.Text = "Refresh";
            this.btnRefreshFriendCode.UseVisualStyleBackColor = true;
            this.btnRefreshFriendCode.Click += new System.EventHandler(this.btnRefreshFriendCode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Friend Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(521, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSGO - Discord Rich Presence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tabCSGO_btnInstall;
        private System.Windows.Forms.Button tabLobby_btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tabLobby_txtState;
        private System.Windows.Forms.TextBox tabLobby_txtDetail;
        private System.Windows.Forms.Button tabIngame_btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tabIngame_txtState;
        private System.Windows.Forms.CheckBox tabIngame_cbShowMap;
        private System.Windows.Forms.CheckBox tabIngame_cbShowTeam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tabIngame_txtDetail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tabIngame_txtLargeText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tabIngame_txtSmallText;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFriendCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRefreshFriendCode;
    }
}

