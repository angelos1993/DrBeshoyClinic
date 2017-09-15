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
    public partial class FrmSurgicalHx : FrmMaster
    {
        #region Constructor

        public FrmSurgicalHx()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private SurgicalHxManager _surgicalHxManager;

        private SurgicalHxManager SurgicalHxManager
            => _surgicalHxManager ?? (_surgicalHxManager = new SurgicalHxManager());

        private List<SurgicalHx> AllPatientSurgicalHxes { get; set; }
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private SurgicalHx TodaysSurgicalHx { get; set; }
        private static DateTime Today => DateTime.Now.Date;

        private bool IsExistPatientSurgicalHxForToday
            => AllPatientSurgicalHxes.Any(surgicalHx => surgicalHx.Date == Today);

        #endregion

        #region Events

        private void FrmSurgicalHx_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveTheCurrentSurgicalHx();
            Close();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstSurgicalHx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadSurgicalHxesForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void txtSurgicalHx_TextChanged(object sender, EventArgs e)
        {
            if (lstSurgicalHx.SelectedItem is ListBoxVm selectedItem && selectedItem.Date == Today)
                TodaysSurgicalHx.Description = txtSurgicalHx.Text;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            AllPatientSurgicalHxes = SurgicalHxManager.GetSurgicalHxesForPatient(Patient.Id).ToList();
            TodaysSurgicalHx = IsExistPatientSurgicalHxForToday
                ? AllPatientSurgicalHxes.FirstOrDefault(surgicalHx => surgicalHx.Date == Today)
                : new SurgicalHx {Date = Today, PatientId = Patient.Id};
            BindSurgicalHxesToListView();
        }

        private void SaveTheCurrentSurgicalHx()
        {
            if (!TodaysSurgicalHx.Description.IsNullOrEmptyOrWhiteSpace())
                SurgicalHxManager.AddOrUpdateSurgicalHx(TodaysSurgicalHx);
        }

        private void LoadSurgicalHxesForSelectedDate()
        {
            var selectedItem = lstSurgicalHx.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            if (selectedItem.Date == Today)
            {
                txtSurgicalHx.Text = TodaysSurgicalHx.Description;
                txtSurgicalHx.ReadOnly = false;
            }
            else
            {
                txtSurgicalHx.Text = AllPatientSurgicalHxes
                    .FirstOrDefault(surgicalHx => surgicalHx.Date == selectedItem.Date)?.Description;
                txtSurgicalHx.ReadOnly = true;
            }
        }

        private void BindSurgicalHxesToListView()
        {
            var lstSurgicalHxesDataSource =
                AllPatientSurgicalHxes.OrderByDescending(surgicalHx => surgicalHx.Date)
                    .GroupBy(surgicalHx => surgicalHx.Date)
                    .Select(surgicalHxDateGroup => new ListBoxVm {Date = surgicalHxDateGroup.Key}).ToList();
            if (!IsExistPatientSurgicalHxForToday)
                lstSurgicalHxesDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstSurgicalHx.DataSource = lstSurgicalHxesDataSource;
            lstSurgicalHx.DisplayMember = ListBoxDisplayMember;
        }

        #endregion
    }
}