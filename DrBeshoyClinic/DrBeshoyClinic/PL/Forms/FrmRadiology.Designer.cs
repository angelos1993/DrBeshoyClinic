namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmRadiology
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
            this.txtRadiology = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRadiologyDescription = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvRadiologies = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lstRadiologies = new System.Windows.Forms.ListBox();
            this.btnAddRadiology = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadiologies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRadiology
            // 
            // 
            // 
            // 
            this.txtRadiology.Border.Class = "TextBoxBorder";
            this.txtRadiology.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRadiology.Location = new System.Drawing.Point(12, 12);
            this.txtRadiology.Name = "txtRadiology";
            this.txtRadiology.Size = new System.Drawing.Size(283, 26);
            this.txtRadiology.TabIndex = 20;
            this.txtRadiology.WatermarkText = "Radiology ...";
            // 
            // txtRadiologyDescription
            // 
            // 
            // 
            // 
            this.txtRadiologyDescription.Border.Class = "TextBoxBorder";
            this.txtRadiologyDescription.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtRadiologyDescription.Location = new System.Drawing.Point(301, 12);
            this.txtRadiologyDescription.Multiline = true;
            this.txtRadiologyDescription.Name = "txtRadiologyDescription";
            this.txtRadiologyDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRadiologyDescription.Size = new System.Drawing.Size(340, 60);
            this.txtRadiologyDescription.TabIndex = 22;
            this.txtRadiologyDescription.WatermarkText = "Radiology Description ...";
            // 
            // dgvRadiologies
            // 
            this.dgvRadiologies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRadiologies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRadiologies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRadiologies.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRadiologies.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvRadiologies.Location = new System.Drawing.Point(12, 76);
            this.dgvRadiologies.Name = "dgvRadiologies";
            this.dgvRadiologies.ReadOnly = true;
            this.dgvRadiologies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRadiologies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRadiologies.Size = new System.Drawing.Size(572, 205);
            this.dgvRadiologies.TabIndex = 23;
            this.dgvRadiologies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRadiologies_CellDoubleClick);
            // 
            // lstRadiologies
            // 
            this.lstRadiologies.FormattingEnabled = true;
            this.lstRadiologies.ItemHeight = 20;
            this.lstRadiologies.Location = new System.Drawing.Point(590, 77);
            this.lstRadiologies.Name = "lstRadiologies";
            this.lstRadiologies.Size = new System.Drawing.Size(120, 204);
            this.lstRadiologies.TabIndex = 30;
            this.lstRadiologies.SelectedIndexChanged += new System.EventHandler(this.lstRadiologies_SelectedIndexChanged);
            // 
            // btnAddRadiology
            // 
            this.btnAddRadiology.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddRadiology.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddRadiology.Image = global::DrBeshoyClinic.Properties.Resources.Add;
            this.btnAddRadiology.ImageFixedSize = new System.Drawing.Size(55, 55);
            this.btnAddRadiology.Location = new System.Drawing.Point(650, 12);
            this.btnAddRadiology.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRadiology.Name = "btnAddRadiology";
            this.btnAddRadiology.Size = new System.Drawing.Size(60, 60);
            this.btnAddRadiology.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddRadiology.TabIndex = 37;
            this.btnAddRadiology.Click += new System.EventHandler(this.btnAddRadiology_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(431, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 40;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrBeshoyClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClear.Location = new System.Drawing.Point(295, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(159, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmRadiology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 343);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddRadiology);
            this.Controls.Add(this.lstRadiologies);
            this.Controls.Add(this.dgvRadiologies);
            this.Controls.Add(this.txtRadiologyDescription);
            this.Controls.Add(this.txtRadiology);
            this.DoubleBuffered = true;
            this.Name = "FrmRadiology";
            this.Text = "Radiology";
            this.Load += new System.EventHandler(this.FrmRadiology_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRadiologies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtRadiology;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRadiologyDescription;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvRadiologies;
        private System.Windows.Forms.ListBox lstRadiologies;
        private DevComponents.DotNetBar.ButtonX btnAddRadiology;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}