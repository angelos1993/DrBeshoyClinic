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
        private List<FamilyHx> AllPatientFamilyHxs { get; set; }
        private FamilyHx TodaysFamilyHx { get; set; }
        private bool IsExistPatientFamilyHxForToday => AllPatientFamilyHxs.Any(familyHx => familyHx.Date == Today);
        private bool ShouldBind { get; set; }

        #endregion

        #region Events

        private void FrmFamilyHx_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FrmFamilyHx_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ShouldBind)
                OwnerForm.BindFamilyHxs(TodaysFamilyHx.Description);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveTheCurrentFamilyHx();
            ShouldBind = true;
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
            LoadFamilyHxsForSelectedDate();
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
            AllPatientFamilyHxs = FamilyHxManager.GetFamilyHxesForPatient(Patient.Id).ToList();
            TodaysFamilyHx = IsExistPatientFamilyHxForToday
                ? AllPatientFamilyHxs.FirstOrDefault(familyHx => familyHx.Date == Today)
                : new FamilyHx {Date = Today, PatientId = Patient.Id};
            BindFamilyHxsToListView();
        }

        private void BindFamilyHxsToListView()
        {
            var lstFamilyHxesDataSource =
                AllPatientFamilyHxs.OrderByDescending(familyHx => familyHx.Date).GroupBy(familyHx => familyHx.Date)
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

        private void LoadFamilyHxsForSelectedDate()
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
                txtFamilyHx.Text = AllPatientFamilyHxs.FirstOrDefault(drugHx => drugHx.Date == selectedItem.Date)
                    ?.Description;
                txtFamilyHx.ReadOnly = true;
            }
        }

        #endregion}
    }
}