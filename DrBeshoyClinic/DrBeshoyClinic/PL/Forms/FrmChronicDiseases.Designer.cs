namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmChronicDiseases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvChronicDiseases = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnAddDiasease = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colDiasease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChronicDiseases)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChronicDiseases
            // 
            this.dgvChronicDiseases.AllowUserToAddRows = false;
            this.dgvChronicDiseases.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChronicDiseases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChronicDiseases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colDiasease,
            this.colNotes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChronicDiseases.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChronicDiseases.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvChronicDiseases.Location = new System.Drawing.Point(12, 12);
            this.dgvChronicDiseases.Name = "dgvChronicDiseases";
            this.dgvChronicDiseases.Size = new System.Drawing.Size(606, 332);
            this.dgvChronicDiseases.TabIndex = 0;
            // 
            // btnAddDiasease
            // 
            this.btnAddDiasease.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDiasease.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddDiasease.Image = global::DrBeshoyClinic.Properties.Resources.Add;
            this.btnAddDiasease.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnAddDiasease.Location = new System.Drawing.Point(32, 350);
            this.btnAddDiasease.Name = "btnAddDiasease";
            this.btnAddDiasease.Size = new System.Drawing.Size(159, 40);
            this.btnAddDiasease.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddDiasease.TabIndex = 9;
            this.btnAddDiasease.Text = "Add Diasease";
            this.btnAddDiasease.Click += new System.EventHandler(this.btnAddDiasease_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrBeshoyClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClear.Location = new System.Drawing.Point(333, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(197, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(469, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // colCheck
            // 
            this.colCheck.FillWeight = 5F;
            this.colCheck.HeaderText = "#";
            this.colCheck.Name = "colCheck";
            this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCheck.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colDiasease
            // 
            this.colDiasease.FillWeight = 40F;
            this.colDiasease.HeaderText = "Disease";
            this.colDiasease.Name = "colDiasease";
            this.colDiasease.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.FillWeight = 55F;
            this.colNotes.HeaderText = "Notes";
            this.colNotes.Name = "colNotes";
            // 
            // FrmChronicDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 402);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddDiasease);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvChronicDiseases);
            this.DoubleBuffered = true;
            this.Name = "FrmChronicDiseases";
            this.Text = "Chronic Diseases";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChronicDiseases_FormClosing);
            this.Load += new System.EventHandler(this.FrmChronicDiseases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChronicDiseases)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvChronicDiseases;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnAddDiasease;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiasease;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
    }
}