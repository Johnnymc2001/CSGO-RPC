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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabLobby_txtState = new System.Windows.Forms.TextBox();
            this.tabLobby_txtDetail = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.tabIngame_txtDetail = new System.Windows.Forms.TextBox();
            this.tabIngame_cbShowTeam = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabIngame_txtState = new System.Windows.Forms.TextBox();
            this.tabIngame_btnSave = new System.Windows.Forms.Button();
            this.tabIngame_cbShowMap = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabIngame_txtSmallText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabIngame_txtLargeText = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage4);
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
            this.tabPage3.Size = new System.Drawing.Size(490, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ingame";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(490, 224);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Placeholders";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 208);
            this.label10.TabIndex = 21;
            this.label10.Text = resources.GetString("label10.Text");
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
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label10;
    }
}

