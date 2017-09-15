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
        private List<DrugHx> AllPatientDrugHxes { get; set; }
        private DrugHx TodaysDrugHx { get; set; }
        private bool IsExistPatientDrugHxForToday => AllPatientDrugHxes.Any(drugHx => drugHx.Date == Today);

        #endregion

        #region Events

        private void FrmDrugHx_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveTheCurrentDrugHx();
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
            LoadDrugHxesForSelectedDate();
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
            AllPatientDrugHxes = DrugHxManager.GetDrugHxesForPatient(Patient.Id).ToList();
            TodaysDrugHx = IsExistPatientDrugHxForToday
                ? AllPatientDrugHxes.FirstOrDefault(drugHx => drugHx.Date == Today)
                : new DrugHx {Date = Today, PatientId = Patient.Id};
            BindDrugHxesToListView();
        }

        private void BindDrugHxesToListView()
        {
            var lstDrugHxesDataSource =
                AllPatientDrugHxes.OrderByDescending(drugHx => drugHx.Date).GroupBy(drugHx => drugHx.Date)
                    .Select(drugHxDateGroup => new ListBoxVm {Date = drugHxDateGroup.Key}).ToList();
            if (!IsExistPatientDrugHxForToday)
                lstDrugHxesDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstDrugHx.DataSource = lstDrugHxesDataSource;
            lstDrugHx.DisplayMember = ListBoxDisplayMember;
        }

        private void SaveTheCurrentDrugHx()
        {
            if (!TodaysDrugHx.Description.IsNullOrEmptyOrWhiteSpace())
                DrugHxManager.AddOrUpdateDrugHx(TodaysDrugHx);
        }

        private void LoadDrugHxesForSelectedDate()
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
                txtDrugHx.Text = AllPatientDrugHxes.FirstOrDefault(drugHx => drugHx.Date == selectedItem.Date)
                    ?.Description;
                txtDrugHx.ReadOnly = true;
            }
        }

        #endregion
    }
}