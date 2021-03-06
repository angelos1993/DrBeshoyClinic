﻿namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmDiagnosis
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
            this.lstDiagnosis = new System.Windows.Forms.ListBox();
            this.dgvDiagnosis = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtDiagnosis = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAddDiagnosis = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDiagnosis
            // 
            this.lstDiagnosis.FormattingEnabled = true;
            this.lstDiagnosis.ItemHeight = 20;
            this.lstDiagnosis.Location = new System.Drawing.Point(425, 46);
            this.lstDiagnosis.Name = "lstDiagnosis";
            this.lstDiagnosis.Size = new System.Drawing.Size(120, 244);
            this.lstDiagnosis.TabIndex = 45;
            this.lstDiagnosis.SelectedIndexChanged += new System.EventHandler(this.lstDiagnosis_SelectedIndexChanged);
            // 
            // dgvDiagnosis
            // 
            this.dgvDiagnosis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiagnosis.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiagnosis.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDiagnosis.Location = new System.Drawing.Point(12, 46);
            this.dgvDiagnosis.Name = "dgvDiagnosis";
            this.dgvDiagnosis.ReadOnly = true;
            this.dgvDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosis.Size = new System.Drawing.Size(407, 244);
            this.dgvDiagnosis.TabIndex = 44;
            this.dgvDiagnosis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiagnosis_CellDoubleClick);
            // 
            // txtDiagnosis
            // 
            // 
            // 
            // 
            this.txtDiagnosis.Border.Class = "TextBoxBorder";
            this.txtDiagnosis.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDiagnosis.Location = new System.Drawing.Point(12, 12);
            this.txtDiagnosis.Name = "txtDiagnosis";
            this.txtDiagnosis.Size = new System.Drawing.Size(501, 26);
            this.txtDiagnosis.TabIndex = 43;
            this.txtDiagnosis.WatermarkText = "Diagnosis ...";
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddDiagnosis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddDiagnosis.Image = global::DrBeshoyClinic.Properties.Resources.Add;
            this.btnAddDiagnosis.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnAddDiagnosis.Location = new System.Drawing.Point(519, 12);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(26, 26);
            this.btnAddDiagnosis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddDiagnosis.TabIndex = 49;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(347, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrBeshoyClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClear.Location = new System.Drawing.Point(211, 296);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 51;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(75, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 339);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.lstDiagnosis);
            this.Controls.Add(this.dgvDiagnosis);
            this.Controls.Add(this.txtDiagnosis);
            this.DoubleBuffered = true;
            this.Name = "FrmDiagnosis";
            this.Text = "Diagnosis";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDiagnosis_FormClosing);
            this.Load += new System.EventHandler(this.FrmDiagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnAddDiagnosis;
        private System.Windows.Forms.ListBox lstDiagnosis;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDiagnosis;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiagnosis;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}