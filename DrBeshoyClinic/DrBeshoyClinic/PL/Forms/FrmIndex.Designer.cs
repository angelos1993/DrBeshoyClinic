namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIndex));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExamination = new DevComponents.DotNetBar.ButtonX();
            this.btnDailyReport = new DevComponents.DotNetBar.ButtonX();
            this.btnDatabase = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DrBeshoyClinic.Properties.Resources.HomeBackground;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(989, 590);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExamination
            // 
            this.btnExamination.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExamination.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExamination.Location = new System.Drawing.Point(295, 344);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(209, 59);
            this.btnExamination.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExamination.TabIndex = 1;
            this.btnExamination.Text = "Examination";
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDailyReport.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDailyReport.Location = new System.Drawing.Point(295, 409);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(209, 59);
            this.btnDailyReport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDailyReport.TabIndex = 2;
            this.btnDailyReport.Text = "Daily Report";
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDatabase.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDatabase.Location = new System.Drawing.Point(295, 474);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(209, 59);
            this.btnDatabase.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDatabase.TabIndex = 3;
            this.btnDatabase.Text = "Database";
            this.btnDatabase.Click += new System.EventHandler(this.btnDatabase_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 590);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.btnDailyReport);
            this.Controls.Add(this.btnExamination);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "D.Beshoy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIndex_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonX btnExamination;
        private DevComponents.DotNetBar.ButtonX btnDailyReport;
        private DevComponents.DotNetBar.ButtonX btnDatabase;
    }
}