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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdLabTests = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.lstLabTests = new System.Windows.Forms.ListBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnAddLabTest = new DevComponents.DotNetBar.ButtonX();
            this.txtTestName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTestResult = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdLabTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grdLabTests
            // 
            this.grdLabTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLabTests.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdLabTests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grdLabTests.Location = new System.Drawing.Point(12, 44);
            this.grdLabTests.Name = "grdLabTests";
            this.grdLabTests.ReadOnly = true;
            this.grdLabTests.Size = new System.Drawing.Size(571, 192);
            this.grdLabTests.TabIndex = 0;
            // 
            // lstLabTests
            // 
            this.lstLabTests.FormattingEnabled = true;
            this.lstLabTests.ItemHeight = 20;
            this.lstLabTests.Location = new System.Drawing.Point(589, 12);
            this.lstLabTests.Name = "lstLabTests";
            this.lstLabTests.Size = new System.Drawing.Size(120, 224);
            this.lstLabTests.TabIndex = 1;
            this.lstLabTests.SelectedIndexChanged += new System.EventHandler(this.lstLabTests_SelectedIndexChanged);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddLabTest
            // 
            this.btnAddLabTest.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddLabTest.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddLabTest.Image = global::DrBeshoyClinic.Properties.Resources.Add;
            this.btnAddLabTest.ImageFixedSize = new System.Drawing.Size(25, 25);
            this.btnAddLabTest.Location = new System.Drawing.Point(557, 12);
            this.btnAddLabTest.Name = "btnAddLabTest";
            this.btnAddLabTest.Size = new System.Drawing.Size(26, 26);
            this.btnAddLabTest.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddLabTest.TabIndex = 51;
            this.btnAddLabTest.Click += new System.EventHandler(this.btnAddLabTest_Click);
            // 
            // txtTestName
            // 
            // 
            // 
            // 
            this.txtTestName.Border.Class = "TextBoxBorder";
            this.txtTestName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTestName.Location = new System.Drawing.Point(12, 12);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.Size = new System.Drawing.Size(266, 26);
            this.txtTestName.TabIndex = 50;
            this.txtTestName.WatermarkText = "Lab Test ...";
            // 
            // txtTestResult
            // 
            // 
            // 
            // 
            this.txtTestResult.Border.Class = "TextBoxBorder";
            this.txtTestResult.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTestResult.Location = new System.Drawing.Point(284, 12);
            this.txtTestResult.Name = "txtTestResult";
            this.txtTestResult.Size = new System.Drawing.Size(267, 26);
            this.txtTestResult.TabIndex = 52;
            this.txtTestResult.WatermarkText = "Lab Test Result ...";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 294);
            this.Controls.Add(this.txtTestResult);
            this.Controls.Add(this.btnAddLabTest);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstLabTests);
            this.Controls.Add(this.grdLabTests);
            this.DoubleBuffered = true;
            this.Name = "FrmLabTest";
            this.Text = "Lab Test";
            this.Load += new System.EventHandler(this.FrmLabTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLabTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX grdLabTests;
        private System.Windows.Forms.ListBox lstLabTests;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnAddLabTest;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTestName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTestResult;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}