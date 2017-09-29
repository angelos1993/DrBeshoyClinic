namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmBackupAndRestore
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
            this.btnBackup = new DevComponents.DotNetBar.ButtonX();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new DevComponents.DotNetBar.LabelX();
            this.btnRestore = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // btnBackup
            // 
            this.btnBackup.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBackup.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBackup.Image = global::DrBeshoyClinic.Properties.Resources.Backup;
            this.btnBackup.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnBackup.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnBackup.Location = new System.Drawing.Point(12, 12);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(150, 150);
            this.btnBackup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup DB";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 168);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(306, 23);
            this.progressBar.TabIndex = 4;
            // 
            // lblProgress
            // 
            // 
            // 
            // 
            this.lblProgress.BackgroundStyle.Class = "";
            this.lblProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProgress.Location = new System.Drawing.Point(128, 197);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(75, 23);
            this.lblProgress.TabIndex = 5;
            this.lblProgress.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnRestore
            // 
            this.btnRestore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRestore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRestore.Image = global::DrBeshoyClinic.Properties.Resources.Restore;
            this.btnRestore.ImageFixedSize = new System.Drawing.Size(80, 70);
            this.btnRestore.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnRestore.Location = new System.Drawing.Point(168, 12);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(150, 150);
            this.btnRestore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore DB";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // FrmBackupAndRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 226);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.DoubleBuffered = true;
            this.Name = "FrmBackupAndRestore";
            this.Text = "Backup & Restore Database";
            this.Load += new System.EventHandler(this.FrmBackupAndRestore_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnBackup;
        private DevComponents.DotNetBar.ButtonX btnRestore;
        private System.Windows.Forms.ProgressBar progressBar;
        private DevComponents.DotNetBar.LabelX lblProgress;
    }
}