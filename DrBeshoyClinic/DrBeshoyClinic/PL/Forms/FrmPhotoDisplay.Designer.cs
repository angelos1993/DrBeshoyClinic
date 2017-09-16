namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmPhotoDisplay
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
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new DevComponents.DotNetBar.ButtonX();
            this.lblCount = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNext.Image = global::DrBeshoyClinic.Properties.Resources.Next;
            this.btnNext.ImageFixedSize = new System.Drawing.Size(100, 70);
            this.btnNext.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNext.Location = new System.Drawing.Point(507, 583);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(159, 66);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.TabIndex = 57;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // picBox
            // 
            this.picBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(884, 577);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrevious.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrevious.Image = global::DrBeshoyClinic.Properties.Resources.Previous;
            this.btnPrevious.ImageFixedSize = new System.Drawing.Size(100, 70);
            this.btnPrevious.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnPrevious.Location = new System.Drawing.Point(219, 583);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(159, 66);
            this.btnPrevious.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrevious.TabIndex = 58;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lblCount
            // 
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblCount.BackgroundStyle.Class = "";
            this.lblCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCount.Location = new System.Drawing.Point(384, 583);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(117, 66);
            this.lblCount.TabIndex = 59;
            this.lblCount.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FrmPhotoDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picBox);
            this.DoubleBuffered = true;
            this.Name = "FrmPhotoDisplay";
            this.Text = "Photo Display";
            this.Load += new System.EventHandler(this.FrmPhotoDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.ButtonX btnPrevious;
        private DevComponents.DotNetBar.LabelX lblCount;
    }
}