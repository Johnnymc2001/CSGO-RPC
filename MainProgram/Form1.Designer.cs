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
            this.btnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAutoStart = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabCSGO_btnInstall = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabLobby_btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLobby_txtState = new System.Windows.Forms.TextBox();
            this.tabLobby_txtDetail = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabIngame_txtState = new System.Windows.Forms.TextBox();
            this.tabIngame_cbShowKDA = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabIngame_btnSave = new System.Windows.Forms.Button();
            this.tabIngame_cbShowGamemode = new System.Windows.Forms.CheckBox();
            this.tabIngame_cbShowMap = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabIngame_cbShowTeam = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 264);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // cbAutoStart
            // 
            this.cbAutoStart.AutoSize = true;
            this.cbAutoStart.Location = new System.Drawing.Point(92, 268);
            this.cbAutoStart.Name = "cbAutoStart";
            this.cbAutoStart.Size = new System.Drawing.Size(68, 17);
            this.cbAutoStart.TabIndex = 4;
            this.cbAutoStart.Text = "Autostart";
            this.cbAutoStart.UseVisualStyleBackColor = true;
            this.cbAutoStart.CheckedChanged += new System.EventHandler(this.cbAutoStart_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 250);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabCSGO_btnInstall);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CS:GO";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "This program require custom Gamestate Intergration CFG File.\r\nClick Install to co" +
    "py the Gamestate Intergration CFG\r\nThe program use Port 4123 ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabLobby_btnSave);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tabLobby_txtState);
            this.tabPage2.Controls.Add(this.tabLobby_txtDetail);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 224);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 39);
            this.label8.TabIndex = 10;
            this.label8.Text = "Some Placeholder You Can Use\r\n{USERNAME} - Your steam\'s name\r\n{ID} - Your steam\'s" +
    " ID\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Details";
            // 
            // tabLobby_txtState
            // 
            this.tabLobby_txtState.Location = new System.Drawing.Point(77, 69);
            this.tabLobby_txtState.Name = "tabLobby_txtState";
            this.tabLobby_txtState.Size = new System.Drawing.Size(407, 20);
            this.tabLobby_txtState.TabIndex = 1;
            // 
            // tabLobby_txtDetail
            // 
            this.tabLobby_txtDetail.Location = new System.Drawing.Point(77, 40);
            this.tabLobby_txtDetail.Name = "tabLobby_txtDetail";
            this.tabLobby_txtDetail.Size = new System.Drawing.Size(407, 20);
            this.tabLobby_txtDetail.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabIngame_cbShowTeam);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tabIngame_txtState);
            this.tabPage3.Controls.Add(this.tabIngame_cbShowKDA);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tabIngame_btnSave);
            this.tabPage3.Controls.Add(this.tabIngame_cbShowGamemode);
            this.tabPage3.Controls.Add(this.tabIngame_cbShowMap);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(490, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ingame";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 78);
            this.label10.TabIndex = 20;
            this.label10.Text = "Placeholders :\r\n{TScore}/{CTScore}  - Team\'s Score\r\n{TName}/{CTName} - Team\'s Nam" +
    "e\r\n{Phase} - Game Phase\r\n{Round} - Current Round\r\n\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "State";
            // 
            // tabIngame_txtState
            // 
            this.tabIngame_txtState.Location = new System.Drawing.Point(44, 33);
            this.tabIngame_txtState.Name = "tabIngame_txtState";
            this.tabIngame_txtState.Size = new System.Drawing.Size(443, 20);
            this.tabIngame_txtState.TabIndex = 18;
            // 
            // tabIngame_cbShowKDA
            // 
            this.tabIngame_cbShowKDA.AutoSize = true;
            this.tabIngame_cbShowKDA.Location = new System.Drawing.Point(76, 78);
            this.tabIngame_cbShowKDA.Name = "tabIngame_cbShowKDA";
            this.tabIngame_cbShowKDA.Size = new System.Drawing.Size(78, 17);
            this.tabIngame_cbShowKDA.TabIndex = 17;
            this.tabIngame_cbShowKDA.Text = "Show KDA";
            this.tabIngame_cbShowKDA.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Small Image";
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
            // tabIngame_cbShowGamemode
            // 
            this.tabIngame_cbShowGamemode.AutoSize = true;
            this.tabIngame_cbShowGamemode.Location = new System.Drawing.Point(92, 59);
            this.tabIngame_cbShowGamemode.Name = "tabIngame_cbShowGamemode";
            this.tabIngame_cbShowGamemode.Size = new System.Drawing.Size(110, 17);
            this.tabIngame_cbShowGamemode.TabIndex = 14;
            this.tabIngame_cbShowGamemode.Text = "Show Gamemode";
            this.tabIngame_cbShowGamemode.UseVisualStyleBackColor = true;
            // 
            // tabIngame_cbShowMap
            // 
            this.tabIngame_cbShowMap.AutoSize = true;
            this.tabIngame_cbShowMap.Location = new System.Drawing.Point(9, 59);
            this.tabIngame_cbShowMap.Name = "tabIngame_cbShowMap";
            this.tabIngame_cbShowMap.Size = new System.Drawing.Size(77, 17);
            this.tabIngame_cbShowMap.TabIndex = 13;
            this.tabIngame_cbShowMap.Text = "Show Map";
            this.tabIngame_cbShowMap.UseVisualStyleBackColor = true;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabIngame_cbShowTeam
            // 
            this.tabIngame_cbShowTeam.AutoSize = true;
            this.tabIngame_cbShowTeam.Location = new System.Drawing.Point(208, 59);
            this.tabIngame_cbShowTeam.Name = "tabIngame_cbShowTeam";
            this.tabIngame_cbShowTeam.Size = new System.Drawing.Size(83, 17);
            this.tabIngame_cbShowTeam.TabIndex = 21;
            this.tabIngame_cbShowTeam.Text = "Show Team";
            this.tabIngame_cbShowTeam.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 299);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cbAutoStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAutoStart;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tabCSGO_btnInstall;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button tabLobby_btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tabLobby_txtState;
        private System.Windows.Forms.TextBox tabLobby_txtDetail;
        private System.Windows.Forms.Button tabIngame_btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tabIngame_txtState;
        private System.Windows.Forms.CheckBox tabIngame_cbShowKDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox tabIngame_cbShowGamemode;
        private System.Windows.Forms.CheckBox tabIngame_cbShowMap;
        private System.Windows.Forms.CheckBox tabIngame_cbShowTeam;
    }
}

