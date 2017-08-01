namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmDrugHx
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
            this.lstDrugHx = new System.Windows.Forms.ListBox();
            this.txtDrugHx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lstDrugHx
            // 
            this.lstDrugHx.FormattingEnabled = true;
            this.lstDrugHx.ItemHeight = 20;
            this.lstDrugHx.Location = new System.Drawing.Point(351, 12);
            this.lstDrugHx.Name = "lstDrugHx";
            this.lstDrugHx.Size = new System.Drawing.Size(120, 124);
            this.lstDrugHx.TabIndex = 38;
            this.lstDrugHx.SelectedIndexChanged += new System.EventHandler(this.lstDrugHx_SelectedIndexChanged);
            // 
            // txtDrugHx
            // 
            // 
            // 
            // 
            this.txtDrugHx.Border.Class = "TextBoxBorder";
            this.txtDrugHx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDrugHx.Location = new System.Drawing.Point(12, 12);
            this.txtDrugHx.Multiline = true;
            this.txtDrugHx.Name = "txtDrugHx";
            this.txtDrugHx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDrugHx.Size = new System.Drawing.Size(333, 124);
            this.txtDrugHx.TabIndex = 36;
            this.txtDrugHx.WatermarkText = "Drug Hx ...";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(244, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(108, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmDrugHx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 191);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstDrugHx);
            this.Controls.Add(this.txtDrugHx);
            this.DoubleBuffered = true;
            this.Name = "FrmDrugHx";
            this.Text = "Drug Hx";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstDrugHx;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDrugHx;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}