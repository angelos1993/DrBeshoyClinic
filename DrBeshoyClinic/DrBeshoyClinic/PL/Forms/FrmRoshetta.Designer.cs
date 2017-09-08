namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmRoshetta
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.roshettaMedicineVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repVwRoshetta = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.roshettaMedicineVmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roshettaMedicineVmBindingSource
            // 
            this.roshettaMedicineVmBindingSource.DataSource = typeof(DrBeshoyClinic.DAL.VMs.RoshettaMedicineVm);
            // 
            // repVwRoshetta
            // 
            this.repVwRoshetta.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RoshettaMedicineDataSet";
            reportDataSource1.Value = this.roshettaMedicineVmBindingSource;
            this.repVwRoshetta.LocalReport.DataSources.Add(reportDataSource1);
            this.repVwRoshetta.LocalReport.ReportEmbeddedResource = "DrBeshoyClinic.PL.Reports.RepRoshetta.rdlc";
            this.repVwRoshetta.Location = new System.Drawing.Point(0, 0);
            this.repVwRoshetta.Name = "repVwRoshetta";
            this.repVwRoshetta.ServerReport.BearerToken = null;
            this.repVwRoshetta.Size = new System.Drawing.Size(684, 741);
            this.repVwRoshetta.TabIndex = 3;
            // 
            // FrmRoshetta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 741);
            this.Controls.Add(this.repVwRoshetta);
            this.DoubleBuffered = true;
            this.Name = "FrmRoshetta";
            this.Text = "Medicine";
            this.Load += new System.EventHandler(this.FrmRoshetta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roshettaMedicineVmBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repVwRoshetta;
        private System.Windows.Forms.BindingSource roshettaMedicineVmBindingSource;
    }
}