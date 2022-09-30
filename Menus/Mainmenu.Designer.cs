
namespace projektGame.Menus
{
    partial class Mainmenu
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
            this.lbDiagnosis = new System.Windows.Forms.Label();
            this.lbName2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btNewPlayer = new System.Windows.Forms.Button();
            this.btOldPlayer = new System.Windows.Forms.Button();
            this.btLoadProfile = new System.Windows.Forms.Button();
            this.btBackLauncher = new System.Windows.Forms.Button();
            this.btLauncherExit = new System.Windows.Forms.Button();
            this.btOptions = new System.Windows.Forms.Button();
            this.btLevel = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDiagnosis
            // 
            this.lbDiagnosis.AutoSize = true;
            this.lbDiagnosis.BackColor = System.Drawing.Color.Wheat;
            this.lbDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagnosis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDiagnosis.Location = new System.Drawing.Point(239, 187);
            this.lbDiagnosis.Name = "lbDiagnosis";
            this.lbDiagnosis.Size = new System.Drawing.Size(0, 20);
            this.lbDiagnosis.TabIndex = 24;
            // 
            // lbName2
            // 
            this.lbName2.AutoSize = true;
            this.lbName2.BackColor = System.Drawing.Color.Wheat;
            this.lbName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName2.Location = new System.Drawing.Point(240, 184);
            this.lbName2.Name = "lbName2";
            this.lbName2.Size = new System.Drawing.Size(156, 22);
            this.lbName2.TabIndex = 19;
            this.lbName2.Text = "                             ";
            this.lbName2.Visible = false;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.Wheat;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbName.Location = new System.Drawing.Point(239, 227);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(169, 24);
            this.tbName.TabIndex = 17;
            this.tbName.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Wheat;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbName.Location = new System.Drawing.Point(111, 229);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(102, 20);
            this.lbName.TabIndex = 16;
            this.lbName.Text = "New Player:";
            this.lbName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(192, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "A little Adventure";
            // 
            // btNewPlayer
            // 
            this.btNewPlayer.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.btNewPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btNewPlayer.Location = new System.Drawing.Point(239, 272);
            this.btNewPlayer.Name = "btNewPlayer";
            this.btNewPlayer.Size = new System.Drawing.Size(169, 49);
            this.btNewPlayer.TabIndex = 26;
            this.btNewPlayer.Text = "New Player";
            this.btNewPlayer.UseVisualStyleBackColor = true;
            this.btNewPlayer.Click += new System.EventHandler(this.btNewPlayer_Click);
            // 
            // btOldPlayer
            // 
            this.btOldPlayer.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.btOldPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOldPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btOldPlayer.Location = new System.Drawing.Point(239, 375);
            this.btOldPlayer.Name = "btOldPlayer";
            this.btOldPlayer.Size = new System.Drawing.Size(169, 50);
            this.btOldPlayer.TabIndex = 25;
            this.btOldPlayer.Text = "Old Player";
            this.btOldPlayer.UseVisualStyleBackColor = true;
            this.btOldPlayer.Click += new System.EventHandler(this.btOldPlayer_Click);
            // 
            // btLoadProfile
            // 
            this.btLoadProfile.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.btLoadProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLoadProfile.Location = new System.Drawing.Point(462, 272);
            this.btLoadProfile.Name = "btLoadProfile";
            this.btLoadProfile.Size = new System.Drawing.Size(117, 30);
            this.btLoadProfile.TabIndex = 23;
            this.btLoadProfile.Text = "Load Profile";
            this.btLoadProfile.UseVisualStyleBackColor = true;
            this.btLoadProfile.Visible = false;
            this.btLoadProfile.Click += new System.EventHandler(this.btLoadProfile_Click);
            // 
            // btBackLauncher
            // 
            this.btBackLauncher.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.btBackLauncher.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btBackLauncher.Location = new System.Drawing.Point(531, 512);
            this.btBackLauncher.Name = "btBackLauncher";
            this.btBackLauncher.Size = new System.Drawing.Size(102, 36);
            this.btBackLauncher.TabIndex = 22;
            this.btBackLauncher.Text = "Back";
            this.btBackLauncher.UseVisualStyleBackColor = true;
            this.btBackLauncher.Visible = false;
            this.btBackLauncher.Click += new System.EventHandler(this.btBackLauncher_Click);
            // 
            // btLauncherExit
            // 
            this.btLauncherExit.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.btLauncherExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLauncherExit.Location = new System.Drawing.Point(415, 512);
            this.btLauncherExit.Name = "btLauncherExit";
            this.btLauncherExit.Size = new System.Drawing.Size(84, 36);
            this.btLauncherExit.TabIndex = 21;
            this.btLauncherExit.Text = "Exit";
            this.btLauncherExit.UseVisualStyleBackColor = true;
            this.btLauncherExit.Click += new System.EventHandler(this.btLauncherExit_Click);
            // 
            // btOptions
            // 
            this.btOptions.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.btOptions.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btOptions.Location = new System.Drawing.Point(80, 512);
            this.btOptions.Name = "btOptions";
            this.btOptions.Size = new System.Drawing.Size(86, 36);
            this.btOptions.TabIndex = 20;
            this.btOptions.Text = "Options";
            this.btOptions.UseVisualStyleBackColor = true;
            this.btOptions.Click += new System.EventHandler(this.btOptions_Click);
            // 
            // btLevel
            // 
            this.btLevel.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.btLevel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btLevel.Location = new System.Drawing.Point(228, 512);
            this.btLevel.Name = "btLevel";
            this.btLevel.Size = new System.Drawing.Size(102, 36);
            this.btLevel.TabIndex = 18;
            this.btLevel.Text = "Go to the Level";
            this.btLevel.UseVisualStyleBackColor = true;
            this.btLevel.Visible = false;
            this.btLevel.Click += new System.EventHandler(this.btLevel_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.Color.Transparent;
            this.btStart.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.btStart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btStart.Location = new System.Drawing.Point(462, 219);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(117, 32);
            this.btStart.TabIndex = 14;
            this.btStart.Text = "Enter the Game";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Visible = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projektGame.Properties.Resources.launcher_Map1;
            this.ClientSize = new System.Drawing.Size(704, 658);
            this.Controls.Add(this.btNewPlayer);
            this.Controls.Add(this.btOldPlayer);
            this.Controls.Add(this.lbDiagnosis);
            this.Controls.Add(this.btLoadProfile);
            this.Controls.Add(this.btBackLauncher);
            this.Controls.Add(this.btLauncherExit);
            this.Controls.Add(this.btOptions);
            this.Controls.Add(this.lbName2);
            this.Controls.Add(this.btLevel);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainmenu";
            this.Load += new System.EventHandler(this.Mainmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNewPlayer;
        private System.Windows.Forms.Button btOldPlayer;
        public System.Windows.Forms.Label lbDiagnosis;
        private System.Windows.Forms.Button btLoadProfile;
        public System.Windows.Forms.Button btBackLauncher;
        private System.Windows.Forms.Button btLauncherExit;
        public System.Windows.Forms.Button btOptions;
        public System.Windows.Forms.Label lbName2;
        public System.Windows.Forms.Button btLevel;
        public System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStart;
    }
}