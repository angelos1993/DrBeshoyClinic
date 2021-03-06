﻿using System;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.Utility;
using Microsoft.Reporting.WinForms;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmDailyReport : FrmMaster
    {
        #region Constructor

        public FrmDailyReport()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private static DateTime Today => DateTime.Now.Date;
        private ExaminationManager _examinationManager;

        private ExaminationManager ExaminationManager
            => _examinationManager ?? (_examinationManager = new ExaminationManager());

        #endregion

        #region Events

        private void FrmDailyReport_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            dtExaminationsDate.Value = Today;
            LoadDate(Today);
            Cursor = Cursors.Default;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadDate(dtExaminationsDate.Value);
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void LoadDate(DateTime dateTime)
        {
            var dateSource = ExaminationManager.GetDailyReportExaminationVms(dateTime);
            DailyReportExaminationVmBindingSource.DataSource = dateSource;
            repVwDailyReport.LocalReport.SetParameters(
                new ReportParameter("Date", dateTime.ToCustomFormattedLongDateString()));
            repVwDailyReport.LocalReport.SetParameters(new ReportParameter("Count", dateSource.Count.ToString()));
            var permissions = new PermissionSet(PermissionState.None);
            permissions.AddPermission(new FileIOPermission(PermissionState.Unrestricted));
            permissions.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            repVwDailyReport.RefreshReport();
        }

        #endregion
    }
}