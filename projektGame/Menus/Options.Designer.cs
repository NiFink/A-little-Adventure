namespace projektGame
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.btOptionsContinue = new System.Windows.Forms.Button();
            this.btMusicOn = new System.Windows.Forms.Button();
            this.btMusicOff = new System.Windows.Forms.Button();
            this.trbVolumeMusic = new System.Windows.Forms.TrackBar();
            this.btOptionsToLau = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumeMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // btOptionsContinue
            // 
            this.btOptionsContinue.BackColor = System.Drawing.Color.Wheat;
            this.btOptionsContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOptionsContinue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btOptionsContinue.Location = new System.Drawing.Point(250, 237);
            this.btOptionsContinue.Name = "btOptionsContinue";
            this.btOptionsContinue.Size = new System.Drawing.Size(109, 38);
            this.btOptionsContinue.TabIndex = 0;
            this.btOptionsContinue.Text = "Continue";
            this.btOptionsContinue.UseVisualStyleBackColor = false;
            this.btOptionsContinue.Visible = false;
            this.btOptionsContinue.Click += new System.EventHandler(this.btOptionsContinue_Click);
            // 
            // btMusicOn
            // 
            this.btMusicOn.BackColor = System.Drawing.Color.Wheat;
            this.btMusicOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMusicOn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btMusicOn.Location = new System.Drawing.Point(79, 86);
            this.btMusicOn.Name = "btMusicOn";
            this.btMusicOn.Size = new System.Drawing.Size(109, 36);
            this.btMusicOn.TabIndex = 1;
            this.btMusicOn.Text = "Music ON";
            this.btMusicOn.UseVisualStyleBackColor = false;
            this.btMusicOn.Click += new System.EventHandler(this.btMusicOn_Click);
            // 
            // btMusicOff
            // 
            this.btMusicOff.BackColor = System.Drawing.Color.Wheat;
            this.btMusicOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMusicOff.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btMusicOff.Location = new System.Drawing.Point(79, 150);
            this.btMusicOff.Name = "btMusicOff";
            this.btMusicOff.Size = new System.Drawing.Size(109, 35);
            this.btMusicOff.TabIndex = 2;
            this.btMusicOff.Text = "Music OFF";
            this.btMusicOff.UseVisualStyleBackColor = false;
            this.btMusicOff.Click += new System.EventHandler(this.btMusicOff_Click);
            // 
            // trbVolumeMusic
            // 
            this.trbVolumeMusic.BackColor = System.Drawing.Color.Wheat;
            this.trbVolumeMusic.Location = new System.Drawing.Point(239, 107);
            this.trbVolumeMusic.Maximum = 100;
            this.trbVolumeMusic.Name = "trbVolumeMusic";
            this.trbVolumeMusic.Size = new System.Drawing.Size(164, 45);
            this.trbVolumeMusic.TabIndex = 3;
            this.trbVolumeMusic.Value = 50;
            this.trbVolumeMusic.Scroll += new System.EventHandler(this.trbVolumeMusic_Scroll);
            // 
            // btOptionsToLau
            // 
            this.btOptionsToLau.BackColor = System.Drawing.Color.Wheat;
            this.btOptionsToLau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOptionsToLau.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btOptionsToLau.Location = new System.Drawing.Point(79, 237);
            this.btOptionsToLau.Name = "btOptionsToLau";
            this.btOptionsToLau.Size = new System.Drawing.Size(116, 38);
            this.btOptionsToLau.TabIndex = 4;
            this.btOptionsToLau.Text = "Exit to Launcher";
            this.btOptionsToLau.UseVisualStyleBackColor = false;
            this.btOptionsToLau.Click += new System.EventHandler(this.btOptionsToLau_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(332, 27);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projektGame.Properties.Resources.latest;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.ControlBox = false;
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btOptionsToLau);
            this.Controls.Add(this.trbVolumeMusic);
            this.Controls.Add(this.btMusicOff);
            this.Controls.Add(this.btMusicOn);
            this.Controls.Add(this.btOptionsContinue);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbVolumeMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btMusicOn;
        private System.Windows.Forms.Button btMusicOff;
        private System.Windows.Forms.TrackBar trbVolumeMusic;
        private System.Windows.Forms.Button btOptionsToLau;
        public System.Windows.Forms.Button btOptionsContinue;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}