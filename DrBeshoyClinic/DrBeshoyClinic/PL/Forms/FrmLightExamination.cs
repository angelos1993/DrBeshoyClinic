using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.DAL.VMs;
using static DrBeshoyClinic.Utility.Constants;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmLightExamination : FrmMaster
    {
        #region Constructor

        public FrmLightExamination()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private FrmExamination OwnerForm => Owner as FrmExamination;
        public List<Examination> AllPatientExaminations { get; set; }
        private string CurrentExamination { get; set; }
        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Events

        private void FrmLightExamination_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OwnerForm.BindExamination(CurrentExamination);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstExamination_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadExaminationForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void txtExamination_TextChanged(object sender, EventArgs e)
        {
            if (lstExamination.SelectedItem is ListBoxVm selectedItem && selectedItem.Date == Today)
                CurrentExamination = txtExamination.Text;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            var lstExaminationsDataSource = AllPatientExaminations.OrderByDescending(examination => examination.Date)
                .GroupBy(examination => examination.Date)
                .Select(examinationDateGroup => new ListBoxVm {Date = examinationDateGroup.Key}).ToList();
            if (AllPatientExaminations.All(examination => examination.Date != Today))
                lstExaminationsDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstExamination.DataSource = lstExaminationsDataSource;
            lstExamination.DisplayMember = ListBoxDisplayMember;
            txtExamination.Text = AllPatientExaminations.Where(examination => examination.Date == Today)
                .Select(examination => examination.ExaminationOfExamination).FirstOrDefault();
        }

        private void LoadExaminationForSelectedDate()
        {
            txtExamination.Clear();
            var selectedItem = lstExamination.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            string selecteExamination;
            if (selectedItem.Date == Today)
            {
                selecteExamination = CurrentExamination;
                txtExamination.ReadOnly = false;
            }
            else
            {
                selecteExamination = AllPatientExaminations.FirstOrDefault(examination
                    => examination.Date == selectedItem.Date)?.ExaminationOfExamination;
                txtExamination.ReadOnly = true;
            }
            txtExamination.Text = selecteExamination;
        }

        #endregion
    }
}