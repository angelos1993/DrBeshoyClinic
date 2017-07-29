namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmComplaints
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
            this.lstComplaints = new System.Windows.Forms.ListBox();
            this.gdvComplaints = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtComplaint = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAddComplaint = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.gdvComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // lstComplaints
            // 
            this.lstComplaints.FormattingEnabled = true;
            this.lstComplaints.ItemHeight = 20;
            this.lstComplaints.Location = new System.Drawing.Point(425, 44);
            this.lstComplaints.Name = "lstComplaints";
            this.lstComplaints.Size = new System.Drawing.Size(120, 244);
            this.lstComplaints.TabIndex = 38;
            // 
            // gdvComplaints
            // 
            this.gdvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdvComplaints.DefaultCellStyle = dataGridViewCellStyle1;
            this.gdvComplaints.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gdvComplaints.Location = new System.Drawing.Point(12, 44);
            this.gdvComplaints.Name = "gdvComplaints";
            this.gdvComplaints.Size = new System.Drawing.Size(407, 244);
            this.gdvComplaints.TabIndex = 37;
            // 
            // txtComplaint
            // 
            // 
            // 
            // 
            this.txtComplaint.Border.Class = "TextBoxBorder";
            this.txtComplaint.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtComplaint.Location = new System.Drawing.Point(12, 12);
            this.txtComplaint.Name = "txtComplaint";
            this.txtComplaint.Size = new System.Drawing.Size(501, 26);
            this.txtComplaint.TabIndex = 34;
            this.txtComplaint.WatermarkText = "Complaint ...";
            // 
            // btnAddComplaint
            // 
            this.btnAddComplaint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddComplaint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddComplaint.Image = global::DrBeshoyClinic.Properties.Resources.Add;
            this.btnAddComplaint.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnAddComplaint.Location = new System.Drawing.Point(519, 12);
            this.btnAddComplaint.Name = "btnAddComplaint";
            this.btnAddComplaint.Size = new System.Drawing.Size(26, 26);
            this.btnAddComplaint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddComplaint.TabIndex = 42;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(347, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Image = global::DrBeshoyClinic.Properties.Resources.Clear;
            this.btnClear.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnClear.Location = new System.Drawing.Point(211, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 40);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(75, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 43;
            this.btnSave.Text = "Save";
            // 
            // FrmComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 339);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddComplaint);
            this.Controls.Add(this.lstComplaints);
            this.Controls.Add(this.gdvComplaints);
            this.Controls.Add(this.txtComplaint);
            this.DoubleBuffered = true;
            this.Name = "FrmComplaints";
            this.Text = "Complaints";
            ((System.ComponentModel.ISupportInitialize)(this.gdvComplaints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstComplaints;
        private DevComponents.DotNetBar.Controls.DataGridViewX gdvComplaints;
        private DevComponents.DotNetBar.Controls.TextBoxX txtComplaint;
        private DevComponents.DotNetBar.ButtonX btnAddComplaint;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnClear;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}