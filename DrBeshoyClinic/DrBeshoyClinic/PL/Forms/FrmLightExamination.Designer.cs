namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmLightExamination
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
            this.lstExamination = new System.Windows.Forms.ListBox();
            this.txtExamination = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lstExamination
            // 
            this.lstExamination.FormattingEnabled = true;
            this.lstExamination.ItemHeight = 20;
            this.lstExamination.Location = new System.Drawing.Point(351, 12);
            this.lstExamination.Name = "lstExamination";
            this.lstExamination.Size = new System.Drawing.Size(120, 124);
            this.lstExamination.TabIndex = 34;
            this.lstExamination.SelectedIndexChanged += new System.EventHandler(this.lstExamination_SelectedIndexChanged);
            // 
            // txtExamination
            // 
            // 
            // 
            // 
            this.txtExamination.Border.Class = "TextBoxBorder";
            this.txtExamination.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtExamination.Location = new System.Drawing.Point(12, 12);
            this.txtExamination.Multiline = true;
            this.txtExamination.Name = "txtExamination";
            this.txtExamination.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExamination.Size = new System.Drawing.Size(333, 124);
            this.txtExamination.TabIndex = 32;
            this.txtExamination.WatermarkText = "Examination ...";
            this.txtExamination.TextChanged += new System.EventHandler(this.txtExamination_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(245, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(109, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmLightExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 193);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstExamination);
            this.Controls.Add(this.txtExamination);
            this.DoubleBuffered = true;
            this.Name = "FrmLightExamination";
            this.Text = "Examination";
            this.Load += new System.EventHandler(this.FrmLightExamination_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstExamination;
        private DevComponents.DotNetBar.Controls.TextBoxX txtExamination;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}