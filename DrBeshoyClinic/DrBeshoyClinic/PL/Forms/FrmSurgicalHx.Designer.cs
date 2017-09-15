namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmSurgicalHx
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
            this.lstSurgicalHx = new System.Windows.Forms.ListBox();
            this.txtSurgicalHx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lstSurgicalHx
            // 
            this.lstSurgicalHx.FormattingEnabled = true;
            this.lstSurgicalHx.ItemHeight = 20;
            this.lstSurgicalHx.Location = new System.Drawing.Point(351, 12);
            this.lstSurgicalHx.Name = "lstSurgicalHx";
            this.lstSurgicalHx.Size = new System.Drawing.Size(120, 124);
            this.lstSurgicalHx.TabIndex = 34;
            this.lstSurgicalHx.SelectedIndexChanged += new System.EventHandler(this.lstSurgicalHx_SelectedIndexChanged);
            // 
            // txtSurgicalHx
            // 
            // 
            // 
            // 
            this.txtSurgicalHx.Border.Class = "TextBoxBorder";
            this.txtSurgicalHx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSurgicalHx.Location = new System.Drawing.Point(12, 12);
            this.txtSurgicalHx.Multiline = true;
            this.txtSurgicalHx.Name = "txtSurgicalHx";
            this.txtSurgicalHx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSurgicalHx.Size = new System.Drawing.Size(333, 124);
            this.txtSurgicalHx.TabIndex = 32;
            this.txtSurgicalHx.WatermarkText = "Surgical Hx ...";
            this.txtSurgicalHx.TextChanged += new System.EventHandler(this.txtSurgicalHx_TextChanged);
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
            this.btnCancel.TabIndex = 37;
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
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmSurgicalHx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 191);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstSurgicalHx);
            this.Controls.Add(this.txtSurgicalHx);
            this.DoubleBuffered = true;
            this.Name = "FrmSurgicalHx";
            this.Text = "Surgical Hx";
            this.Load += new System.EventHandler(this.FrmSurgicalHx_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstSurgicalHx;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSurgicalHx;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}