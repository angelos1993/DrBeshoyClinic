namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmMedicine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMedicine = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMedicinePeriod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMedicineDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAddMedicine = new DevComponents.DotNetBar.ButtonX();
            this.dgvTreatments = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lstMedicines = new System.Windows.Forms.ListBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMedicine
            // 
            // 
            // 
            // 
            this.txtMedicine.Border.Class = "TextBoxBorder";
            this.txtMedicine.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMedicine.Location = new System.Drawing.Point(12, 12);
            this.txtMedicine.Name = "txtMedicine";
            this.txtMedicine.Size = new System.Drawing.Size(250, 26);
            this.txtMedicine.TabIndex = 14;
            this.txtMedicine.WatermarkText = "Medicine ...";
            // 
            // txtMedicinePeriod
            // 
            // 
            // 
            // 
            this.txtMedicinePeriod.Border.Class = "TextBoxBorder";
            this.txtMedicinePeriod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMedicinePeriod.Location = new System.Drawing.Point(268, 12);
            this.txtMedicinePeriod.Name = "txtMedicinePeriod";
            this.txtMedicinePeriod.Size = new System.Drawing.Size(250, 26);
            this.txtMedicinePeriod.TabIndex = 15;
            this.txtMedicinePeriod.WatermarkText = "Medicine Period ...";
            // 
            // txtMedicineDescription
            // 
            // 
            // 
            // 
            this.txtMedicineDescription.Border.Class = "TextBoxBorder";
            this.txtMedicineDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMedicineDescription.Location = new System.Drawing.Point(524, 12);
            this.txtMedicineDescription.Name = "txtMedicineDescription";
            this.txtMedicineDescription.Size = new System.Drawing.Size(250, 26);
            this.txtMedicineDescription.TabIndex = 16;
            this.txtMedicineDescription.WatermarkText = "Medicine Description ...";
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddMedicine.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddMedicine.Image = global::DrBeshoyClinic.Properties.Resources.Add;
            this.btnAddMedicine.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnAddMedicine.Location = new System.Drawing.Point(781, 12);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(26, 26);
            this.btnAddMedicine.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddMedicine.TabIndex = 17;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreatments.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTreatments.Location = new System.Drawing.Point(12, 44);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.Size = new System.Drawing.Size(669, 244);
            this.dgvTreatments.TabIndex = 18;
            // 
            // lstMedicines
            // 
            this.lstMedicines.FormattingEnabled = true;
            this.lstMedicines.ItemHeight = 20;
            this.lstMedicines.Location = new System.Drawing.Point(687, 44);
            this.lstMedicines.Name = "lstMedicines";
            this.lstMedicines.Size = new System.Drawing.Size(120, 244);
            this.lstMedicines.TabIndex = 30;
            this.lstMedicines.SelectedIndexChanged += new System.EventHandler(this.lstMedicines_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(480, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrBeshoyClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClear.Location = new System.Drawing.Point(344, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(208, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 342);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstMedicines);
            this.Controls.Add(this.dgvTreatments);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.txtMedicineDescription);
            this.Controls.Add(this.txtMedicinePeriod);
            this.Controls.Add(this.txtMedicine);
            this.DoubleBuffered = true;
            this.Name = "FrmMedicine";
            this.Text = "Medicine";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtMedicine;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMedicinePeriod;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMedicineDescription;
        private DevComponents.DotNetBar.ButtonX btnAddMedicine;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTreatments;
        private System.Windows.Forms.ListBox lstMedicines;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}