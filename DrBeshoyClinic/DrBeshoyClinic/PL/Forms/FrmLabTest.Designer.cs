namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmLabTest
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
            this.grdLabTests = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colLabTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLabTestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstLabTests = new System.Windows.Forms.ListBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.grdLabTests)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLabTests
            // 
            this.grdLabTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLabTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLabTest,
            this.colLabTestResult});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLabTests.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdLabTests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdLabTests.Location = new System.Drawing.Point(12, 12);
            this.grdLabTests.Name = "grdLabTests";
            this.grdLabTests.Size = new System.Drawing.Size(571, 224);
            this.grdLabTests.TabIndex = 0;
            // 
            // colLabTest
            // 
            this.colLabTest.FillWeight = 35F;
            this.colLabTest.HeaderText = "Lab Test";
            this.colLabTest.Name = "colLabTest";
            // 
            // colLabTestResult
            // 
            this.colLabTestResult.FillWeight = 47.71573F;
            this.colLabTestResult.HeaderText = "Lab Test Result";
            this.colLabTestResult.Name = "colLabTestResult";
            // 
            // lstLabTests
            // 
            this.lstLabTests.FormattingEnabled = true;
            this.lstLabTests.ItemHeight = 20;
            this.lstLabTests.Location = new System.Drawing.Point(589, 12);
            this.lstLabTests.Name = "lstLabTests";
            this.lstLabTests.Size = new System.Drawing.Size(120, 224);
            this.lstLabTests.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(363, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(227, 242);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Save";
            // 
            // FrmLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 294);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstLabTests);
            this.Controls.Add(this.grdLabTests);
            this.DoubleBuffered = true;
            this.Name = "FrmLabTest";
            this.Text = "Lab Test";
            ((System.ComponentModel.ISupportInitialize)(this.grdLabTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdLabTests;
        private System.Windows.Forms.ListBox lstLabTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLabTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLabTestResult;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}