﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.DAL.VMs;
using DrBeshoyClinic.Utility;
using static DrBeshoyClinic.Utility.Constants;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmFamilyHx : FrmMaster
    {
        #region Constructor

        public FrmFamilyHx()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private FamilyHxManager _familyHxManager;

        private FamilyHxManager FamilyHxManager => _familyHxManager ?? (_familyHxManager = new FamilyHxManager());
        private static DateTime Today => DateTime.Now.Date;
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<FamilyHx> AllPatientFamilyHxes { get; set; }
        private FamilyHx TodaysFamilyHx { get; set; }
        private bool IsExistPatientFamilyHxForToday => AllPatientFamilyHxes.Any(familyHx => familyHx.Date == Today);

        #endregion

        #region Events

        private void FrmFamilyHx_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveTheCurrentFamilyHx();
            Close();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstFamilyHx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadFamilyHxesForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void txtFamilyHx_TextChanged(object sender, EventArgs e)
        {
            if (lstFamilyHx.SelectedItem is ListBoxVm selectedItem && selectedItem.Date == Today)
                TodaysFamilyHx.Description = txtFamilyHx.Text;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            AllPatientFamilyHxes = FamilyHxManager.GetFamilyHxesForPatient(Patient.Id).ToList();
            TodaysFamilyHx = IsExistPatientFamilyHxForToday
                ? AllPatientFamilyHxes.FirstOrDefault(familyHx => familyHx.Date == Today)
                : new FamilyHx {Date = Today, PatientId = Patient.Id};
            BindFamilyHxesToListView();
        }

        private void BindFamilyHxesToListView()
        {
            var lstFamilyHxesDataSource =
                AllPatientFamilyHxes.OrderByDescending(familyHx => familyHx.Date).GroupBy(familyHx => familyHx.Date)
                    .Select(familyHxDateGroup => new ListBoxVm {Date = familyHxDateGroup.Key}).ToList();
            if (!IsExistPatientFamilyHxForToday)
                lstFamilyHxesDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstFamilyHx.DataSource = lstFamilyHxesDataSource;
            lstFamilyHx.DisplayMember = ListBoxDisplayMember;
        }

        private void SaveTheCurrentFamilyHx()
        {
            if (!TodaysFamilyHx.Description.IsNullOrEmptyOrWhiteSpace())
                FamilyHxManager.AddOrUpdateFamilyHx(TodaysFamilyHx);
        }

        private void LoadFamilyHxesForSelectedDate()
        {
            var selectedItem = lstFamilyHx.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            if (selectedItem.Date == Today)
            {
                txtFamilyHx.Text = TodaysFamilyHx.Description;
                txtFamilyHx.ReadOnly = false;
            }
            else
            {
                txtFamilyHx.Text = AllPatientFamilyHxes.FirstOrDefault(drugHx => drugHx.Date == selectedItem.Date)
                    ?.Description;
                txtFamilyHx.ReadOnly = true;
            }
        }

        #endregion}
    }
}