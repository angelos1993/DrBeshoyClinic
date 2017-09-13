using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using DevComponents.DotNetBar.Controls;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.DAL.VMs;
using DrBeshoyClinic.Utility;
using static DrBeshoyClinic.Utility.Constants;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmEmgNcv : FrmMaster
    {
        #region Constructor

        public FrmEmgNcv()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private EmgNcvManager _emgNcvManager;

        private EmgNcvManager EmgNcvManager => _emgNcvManager ?? (_emgNcvManager = new EmgNcvManager());
        private static DateTime Today => DateTime.Now.Date;
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<EmgNcv> AllPatientEmgNcvs { get; set; }
        private EmgNcv TodaysEmgNcv { get; set; }
        private bool IsExistPatientEmgNcvForToday => AllPatientEmgNcvs.Any(emgNcv => emgNcv.Date == Today);

        #endregion

        #region Events

        private void FrmEmgNcv_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveTheCurrentEmgNcv();
            Close();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstEmgNcv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadEmgNcvsForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void emgNcv_TextChanged(object sender, EventArgs e)
        {
            if (!(lstEmgNcv.SelectedItem is ListBoxVm selectedItem) || selectedItem.Date != Today)
                return;
            switch ((sender as TextBoxX)?.Name)
            {
                case "txtEmg":
                    TodaysEmgNcv.Emg = txtEmg.Text.FullTrim();
                    break;
                case "txtNcv":
                    TodaysEmgNcv.Ncv = txtNcv.Text.FullTrim();
                    break;
            }
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            AllPatientEmgNcvs = EmgNcvManager.GetEmgNcvsForPatient(Patient.Id).ToList();
            TodaysEmgNcv = IsExistPatientEmgNcvForToday
                ? AllPatientEmgNcvs.FirstOrDefault(emgNcv => emgNcv.Date == Today)
                : new EmgNcv {Date = Today, PatientId = Patient.Id};
            BindEmgNcvsToListView();
        }

        private void BindEmgNcvsToListView()
        {
            var lstEmgNcvsDataSource =
                AllPatientEmgNcvs.OrderByDescending(emgNcv => emgNcv.Date).GroupBy(emgNcv => emgNcv.Date)
                    .Select(emgNcvDateGroup => new ListBoxVm {Date = emgNcvDateGroup.Key}).ToList();
            if (!IsExistPatientEmgNcvForToday)
                lstEmgNcvsDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstEmgNcv.DataSource = lstEmgNcvsDataSource;
            lstEmgNcv.DisplayMember = ListBoxDisplayMember;
        }

        private void SaveTheCurrentEmgNcv()
        {
            if (!TodaysEmgNcv.Emg.IsNullOrEmptyOrWhiteSpace() || !TodaysEmgNcv.Ncv.IsNullOrEmptyOrWhiteSpace())
                EmgNcvManager.AddOrUpdateEmgNcv(TodaysEmgNcv);
        }

        private void LoadEmgNcvsForSelectedDate()
        {
            var selectedItem = lstEmgNcv.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            if (selectedItem.Date == Today)
            {
                txtEmg.Text = TodaysEmgNcv.Emg;
                txtNcv.Text = TodaysEmgNcv.Ncv;
                txtEmg.ReadOnly = txtNcv.ReadOnly = false;
            }
            else
            {
                var selectedEmgNcv = AllPatientEmgNcvs.FirstOrDefault(emgNcv => emgNcv.Date == selectedItem.Date);
                txtEmg.Text = selectedEmgNcv?.Emg;
                txtNcv.Text = selectedEmgNcv?.Ncv;
                txtEmg.ReadOnly = txtNcv.ReadOnly = true;
            }
        }

        #endregion
    }
}