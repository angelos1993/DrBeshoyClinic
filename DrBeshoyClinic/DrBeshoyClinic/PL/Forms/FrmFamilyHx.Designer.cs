namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmFamilyHx
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
            this.txtFamilyHx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lstFamilyHx = new System.Windows.Forms.ListBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtFamilyHx
            // 
            // 
            // 
            // 
            this.txtFamilyHx.Border.Class = "TextBoxBorder";
            this.txtFamilyHx.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFamilyHx.Location = new System.Drawing.Point(12, 12);
            this.txtFamilyHx.Multiline = true;
            this.txtFamilyHx.Name = "txtFamilyHx";
            this.txtFamilyHx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFamilyHx.Size = new System.Drawing.Size(333, 124);
            this.txtFamilyHx.TabIndex = 22;
            this.txtFamilyHx.WatermarkText = "Family Hx ...";
            this.txtFamilyHx.TextChanged += new System.EventHandler(this.txtFamilyHx_TextChanged);
            // 
            // lstFamilyHx
            // 
            this.lstFamilyHx.FormattingEnabled = true;
            this.lstFamilyHx.ItemHeight = 20;
            this.lstFamilyHx.Location = new System.Drawing.Point(351, 12);
            this.lstFamilyHx.Name = "lstFamilyHx";
            this.lstFamilyHx.Size = new System.Drawing.Size(120, 124);
            this.lstFamilyHx.TabIndex = 30;
            this.lstFamilyHx.SelectedIndexChanged += new System.EventHandler(this.lstFamilyHx_SelectedIndexChanged);
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
            this.btnCancel.TabIndex = 33;
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
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmFamilyHx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 193);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstFamilyHx);
            this.Controls.Add(this.txtFamilyHx);
            this.DoubleBuffered = true;
            this.Name = "FrmFamilyHx";
            this.Text = "Family Hx";
            this.Load += new System.EventHandler(this.FrmFamilyHx_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtFamilyHx;
        private System.Windows.Forms.ListBox lstFamilyHx;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}