namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmDailyReport
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
            this.DailyReportExaminationVmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtExaminationsDate = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.repVwDailyReport = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DailyReportExaminationVmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExaminationsDate)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyReportExaminationVmBindingSource
            // 
            this.DailyReportExaminationVmBindingSource.DataSource = typeof(DrBeshoyClinic.DAL.VMs.DailyReportExaminationVm);
            // 
            // dtExaminationsDate
            // 
            // 
            // 
            // 
            this.dtExaminationsDate.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtExaminationsDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtExaminationsDate.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtExaminationsDate.ButtonDropDown.Visible = true;
            this.dtExaminationsDate.Location = new System.Drawing.Point(12, 12);
            // 
            // 
            // 
            this.dtExaminationsDate.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtExaminationsDate.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtExaminationsDate.MonthCalendar.BackgroundStyle.Class = "";
            this.dtExaminationsDate.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtExaminationsDate.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtExaminationsDate.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtExaminationsDate.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtExaminationsDate.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtExaminationsDate.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtExaminationsDate.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtExaminationsDate.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtExaminationsDate.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dtExaminationsDate.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtExaminationsDate.MonthCalendar.DisplayMonth = new System.DateTime(2017, 7, 1, 0, 0, 0, 0);
            this.dtExaminationsDate.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtExaminationsDate.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtExaminationsDate.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtExaminationsDate.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtExaminationsDate.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtExaminationsDate.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dtExaminationsDate.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtExaminationsDate.MonthCalendar.TodayButtonVisible = true;
            this.dtExaminationsDate.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtExaminationsDate.Name = "dtExaminationsDate";
            this.dtExaminationsDate.Size = new System.Drawing.Size(200, 26);
            this.dtExaminationsDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtExaminationsDate.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSearch.Location = new System.Drawing.Point(218, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(135, 26);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Get Report";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // repVwDailyReport
            // 
            this.repVwDailyReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DailyReportExaminationDataSet";
            reportDataSource1.Value = this.DailyReportExaminationVmBindingSource;
            this.repVwDailyReport.LocalReport.DataSources.Add(reportDataSource1);
            this.repVwDailyReport.LocalReport.ReportEmbeddedResource = "DrBeshoyClinic.PL.Reports.RepDailyReport.rdlc";
            this.repVwDailyReport.Location = new System.Drawing.Point(0, 44);
            this.repVwDailyReport.Name = "repVwDailyReport";
            this.repVwDailyReport.ServerReport.BearerToken = null;
            this.repVwDailyReport.Size = new System.Drawing.Size(644, 617);
            this.repVwDailyReport.TabIndex = 2;
            // 
            // FrmDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 661);
            this.Controls.Add(this.repVwDailyReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtExaminationsDate);
            this.DoubleBuffered = true;
            this.Name = "FrmDailyReport";
            this.Text = "FrmDailyReport";
            this.Load += new System.EventHandler(this.FrmDailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DailyReportExaminationVmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtExaminationsDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtExaminationsDate;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private Microsoft.Reporting.WinForms.ReportViewer repVwDailyReport;
        private System.Windows.Forms.BindingSource DailyReportExaminationVmBindingSource;
    }
}