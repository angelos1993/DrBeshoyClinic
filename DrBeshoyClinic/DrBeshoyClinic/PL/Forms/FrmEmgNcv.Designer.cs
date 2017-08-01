namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmEmgNcv
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
            this.txtEmg = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNcv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lstEmgNcv = new System.Windows.Forms.ListBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // txtEmg
            // 
            // 
            // 
            // 
            this.txtEmg.Border.Class = "TextBoxBorder";
            this.txtEmg.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmg.Location = new System.Drawing.Point(12, 12);
            this.txtEmg.Multiline = true;
            this.txtEmg.Name = "txtEmg";
            this.txtEmg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmg.Size = new System.Drawing.Size(417, 66);
            this.txtEmg.TabIndex = 22;
            this.txtEmg.WatermarkText = "EMG ...";
            // 
            // txtNcv
            // 
            // 
            // 
            // 
            this.txtNcv.Border.Class = "TextBoxBorder";
            this.txtNcv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNcv.Location = new System.Drawing.Point(12, 90);
            this.txtNcv.Multiline = true;
            this.txtNcv.Name = "txtNcv";
            this.txtNcv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNcv.Size = new System.Drawing.Size(417, 66);
            this.txtNcv.TabIndex = 23;
            this.txtNcv.WatermarkText = "NCV ...";
            // 
            // lstEmgNcv
            // 
            this.lstEmgNcv.FormattingEnabled = true;
            this.lstEmgNcv.ItemHeight = 20;
            this.lstEmgNcv.Location = new System.Drawing.Point(445, 12);
            this.lstEmgNcv.Name = "lstEmgNcv";
            this.lstEmgNcv.Size = new System.Drawing.Size(120, 144);
            this.lstEmgNcv.TabIndex = 24;
            this.lstEmgNcv.SelectedIndexChanged += new System.EventHandler(this.lstEmgNcv_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(359, 162);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrBeshoyClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClear.Location = new System.Drawing.Point(223, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(87, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmEmgNcv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 208);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstEmgNcv);
            this.Controls.Add(this.txtNcv);
            this.Controls.Add(this.txtEmg);
            this.DoubleBuffered = true;
            this.Name = "FrmEmgNcv";
            this.Text = "EMG - NCV";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtEmg;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNcv;
        private System.Windows.Forms.ListBox lstEmgNcv;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}