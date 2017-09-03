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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTreatment = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTreatmentPeriod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTreatmentDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvTreatments = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lstMedicines = new System.Windows.Forms.ListBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnAddMedicine = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTreatment
            // 
            // 
            // 
            // 
            this.txtTreatment.Border.Class = "TextBoxBorder";
            this.txtTreatment.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTreatment.Location = new System.Drawing.Point(12, 12);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(250, 26);
            this.txtTreatment.TabIndex = 14;
            this.txtTreatment.WatermarkText = "Medicine ...";
            // 
            // txtTreatmentPeriod
            // 
            // 
            // 
            // 
            this.txtTreatmentPeriod.Border.Class = "TextBoxBorder";
            this.txtTreatmentPeriod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTreatmentPeriod.Location = new System.Drawing.Point(268, 12);
            this.txtTreatmentPeriod.Name = "txtTreatmentPeriod";
            this.txtTreatmentPeriod.Size = new System.Drawing.Size(250, 26);
            this.txtTreatmentPeriod.TabIndex = 15;
            this.txtTreatmentPeriod.WatermarkText = "Medicine Period ...";
            // 
            // txtTreatmentDescription
            // 
            // 
            // 
            // 
            this.txtTreatmentDescription.Border.Class = "TextBoxBorder";
            this.txtTreatmentDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTreatmentDescription.Location = new System.Drawing.Point(524, 12);
            this.txtTreatmentDescription.Name = "txtTreatmentDescription";
            this.txtTreatmentDescription.Size = new System.Drawing.Size(250, 26);
            this.txtTreatmentDescription.TabIndex = 16;
            this.txtTreatmentDescription.WatermarkText = "Medicine Description ...";
            // 
            // dgvTreatments
            // 
            this.dgvTreatments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTreatments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTreatments.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTreatments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTreatments.Location = new System.Drawing.Point(12, 44);
            this.dgvTreatments.Name = "dgvTreatments";
            this.dgvTreatments.ReadOnly = true;
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.Image = global::DrBeshoyClinic.Properties.Resources.Print;
            this.btnPrint.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnPrint.Location = new System.Drawing.Point(276, 294);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 40);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 34;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(548, 294);
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
            this.btnClear.Location = new System.Drawing.Point(412, 294);
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
            this.btnSave.Location = new System.Drawing.Point(140, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // FrmMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 342);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstMedicines);
            this.Controls.Add(this.dgvTreatments);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.txtTreatmentDescription);
            this.Controls.Add(this.txtTreatmentPeriod);
            this.Controls.Add(this.txtTreatment);
            this.DoubleBuffered = true;
            this.Name = "FrmMedicine";
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.FrmMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTreatments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatment;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatmentPeriod;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTreatmentDescription;
        private DevComponents.DotNetBar.ButtonX btnAddMedicine;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTreatments;
        private System.Windows.Forms.ListBox lstMedicines;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}