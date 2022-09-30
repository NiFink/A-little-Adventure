namespace projektGame
{
    partial class Menu
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
            this.btMenuOpt = new System.Windows.Forms.Button();
            this.btMenuSave = new System.Windows.Forms.Button();
            this.btMenuContinue = new System.Windows.Forms.Button();
            this.btMenuLau = new System.Windows.Forms.Button();
            this.pbseeSave = new System.Windows.Forms.PictureBox();
            this.lbDiagnosis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbseeSave)).BeginInit();
            this.SuspendLayout();
            // 
            // btMenuOpt
            // 
            this.btMenuOpt.BackColor = System.Drawing.Color.Wheat;
            this.btMenuOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuOpt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btMenuOpt.Location = new System.Drawing.Point(70, 214);
            this.btMenuOpt.Name = "btMenuOpt";
            this.btMenuOpt.Size = new System.Drawing.Size(137, 45);
            this.btMenuOpt.TabIndex = 0;
            this.btMenuOpt.Text = "Options";
            this.btMenuOpt.UseVisualStyleBackColor = false;
            this.btMenuOpt.Click += new System.EventHandler(this.btMenuOpt_Click);
            // 
            // btMenuSave
            // 
            this.btMenuSave.BackColor = System.Drawing.Color.Wheat;
            this.btMenuSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuSave.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btMenuSave.Location = new System.Drawing.Point(70, 136);
            this.btMenuSave.Name = "btMenuSave";
            this.btMenuSave.Size = new System.Drawing.Size(137, 46);
            this.btMenuSave.TabIndex = 1;
            this.btMenuSave.Text = "Save";
            this.btMenuSave.UseVisualStyleBackColor = false;
            this.btMenuSave.Click += new System.EventHandler(this.btMenuSave_Click);
            // 
            // btMenuContinue
            // 
            this.btMenuContinue.BackColor = System.Drawing.Color.Wheat;
            this.btMenuContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuContinue.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btMenuContinue.Location = new System.Drawing.Point(70, 59);
            this.btMenuContinue.Name = "btMenuContinue";
            this.btMenuContinue.Size = new System.Drawing.Size(137, 46);
            this.btMenuContinue.TabIndex = 2;
            this.btMenuContinue.Text = "Continue";
            this.btMenuContinue.UseVisualStyleBackColor = false;
            this.btMenuContinue.Click += new System.EventHandler(this.btMenuContinue_Click);
            // 
            // btMenuLau
            // 
            this.btMenuLau.BackColor = System.Drawing.Color.Wheat;
            this.btMenuLau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenuLau.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btMenuLau.Location = new System.Drawing.Point(70, 285);
            this.btMenuLau.Name = "btMenuLau";
            this.btMenuLau.Size = new System.Drawing.Size(137, 46);
            this.btMenuLau.TabIndex = 3;
            this.btMenuLau.Text = "Back to Launcher";
            this.btMenuLau.UseVisualStyleBackColor = false;
            this.btMenuLau.Click += new System.EventHandler(this.btMenuLau_Click);
            // 
            // pbseeSave
            // 
            this.pbseeSave.BackColor = System.Drawing.Color.Red;
            this.pbseeSave.Location = new System.Drawing.Point(213, 150);
            this.pbseeSave.Name = "pbseeSave";
            this.pbseeSave.Size = new System.Drawing.Size(24, 18);
            this.pbseeSave.TabIndex = 4;
            this.pbseeSave.TabStop = false;
            // 
            // lbDiagnosis
            // 
            this.lbDiagnosis.AutoSize = true;
            this.lbDiagnosis.BackColor = System.Drawing.Color.Wheat;
            this.lbDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiagnosis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDiagnosis.Location = new System.Drawing.Point(80, 32);
            this.lbDiagnosis.Name = "lbDiagnosis";
            this.lbDiagnosis.Size = new System.Drawing.Size(0, 20);
            this.lbDiagnosis.TabIndex = 12;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projektGame.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(276, 401);
            this.Controls.Add(this.lbDiagnosis);
            this.Controls.Add(this.pbseeSave);
            this.Controls.Add(this.btMenuLau);
            this.Controls.Add(this.btMenuContinue);
            this.Controls.Add(this.btMenuSave);
            this.Controls.Add(this.btMenuOpt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbseeSave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMenuOpt;
        private System.Windows.Forms.Button btMenuSave;
        private System.Windows.Forms.Button btMenuContinue;
        private System.Windows.Forms.Button btMenuLau;
        private System.Windows.Forms.PictureBox pbseeSave;
        public System.Windows.Forms.Label lbDiagnosis;
    }
}