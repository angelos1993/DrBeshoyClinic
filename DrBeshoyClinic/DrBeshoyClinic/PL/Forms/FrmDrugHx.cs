using System;
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
    public partial class FrmDrugHx : FrmMaster
    {
        #region Constructor

        public FrmDrugHx()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private DrugHxManager _drugHxManager;
        private DrugHxManager DrugHxManager => _drugHxManager ?? (_drugHxManager = new DrugHxManager());
        private static DateTime Today => DateTime.Now.Date;
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<DrugHx> AllPatientDrugHxs { get; set; }
        private DrugHx TodaysDrugHx { get; set; }
        private bool IsExistPatientDrugHxForToday => AllPatientDrugHxs.Any(drugHx => drugHx.Date == Today);
        private bool ShouldBind { get; set; }

        #endregion

        #region Events

        private void FrmDrugHx_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FrmDrugHx_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ShouldBind)
                OwnerForm.BindDrugHxs(TodaysDrugHx.Description);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveTheCurrentDrugHx();
            ShouldBind = true;
            Close();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstDrugHx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadDrugHxsForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void txtDrugHx_TextChanged(object sender, EventArgs e)
        {
            if (lstDrugHx.SelectedItem is ListBoxVm selectedItem && selectedItem.Date == Today)
                TodaysDrugHx.Description = txtDrugHx.Text;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            AllPatientDrugHxs = DrugHxManager.GetDrugHxesForPatient(Patient.Id).ToList();
            TodaysDrugHx = IsExistPatientDrugHxForToday
                ? AllPatientDrugHxs.FirstOrDefault(drugHx => drugHx.Date == Today)
                : new DrugHx {Date = Today, PatientId = Patient.Id};
            BindDrugHxsToListView();
        }

        private void BindDrugHxsToListView()
        {
            var lstDrugHxsDataSource =
                AllPatientDrugHxs.OrderByDescending(drugHx => drugHx.Date).GroupBy(drugHx => drugHx.Date)
                    .Select(drugHxDateGroup => new ListBoxVm {Date = drugHxDateGroup.Key}).ToList();
            if (!IsExistPatientDrugHxForToday)
                lstDrugHxsDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstDrugHx.DataSource = lstDrugHxsDataSource;
            lstDrugHx.DisplayMember = ListBoxDisplayMember;
        }

        private void SaveTheCurrentDrugHx()
        {
            if (!TodaysDrugHx.Description.IsNullOrEmptyOrWhiteSpace())
                DrugHxManager.AddOrUpdateDrugHx(TodaysDrugHx);
        }

        private void LoadDrugHxsForSelectedDate()
        {
            var selectedItem = lstDrugHx.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            if (selectedItem.Date == Today)
            {
                txtDrugHx.Text = TodaysDrugHx.Description;
                txtDrugHx.ReadOnly = false;
            }
            else
            {
                txtDrugHx.Text = AllPatientDrugHxs.FirstOrDefault(drugHx => drugHx.Date == selectedItem.Date)
                    ?.Description;
                txtDrugHx.ReadOnly = true;
            }
        }

        #endregion
    }
}