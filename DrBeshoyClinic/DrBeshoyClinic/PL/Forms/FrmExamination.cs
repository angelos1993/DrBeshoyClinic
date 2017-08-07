using System;
using System.Linq;
using System.Windows.Forms;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.DAL.VMs;
using DrBeshoyClinic.Properties;
using DrBeshoyClinic.Utility;
using DrBeshoyClinic.Utility.Enums;
using static DrBeshoyClinic.Utility.Constants;
using static DrBeshoyClinic.Utility.MessageBoxUtility;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmExamination : FrmMaster
    {
        #region Constructor

        public FrmExamination()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private PatientManager _patientManager;
        private PatientManager PatientManager => _patientManager ?? (_patientManager = new PatientManager());

        private ExaminationManager _examinationManager;

        private ExaminationManager ExaminationManager
            => _examinationManager ?? (_examinationManager = new ExaminationManager());

        public ExaminationFormMode Mode { get; set; }
        public Patient Patient { get; set; }
        public Examination Examination { get; set; }

        #endregion

        #region Events

        #region Form Events

        private void FrmExamination_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        #endregion

        #region Patient Events

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            FindPatient();
            Cursor = Cursors.Default;
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddNewPatient();
            Cursor = Cursors.Default;
        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            EditPatient();
            Cursor = Cursors.Default;
        }

        private void btnClearPatient_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetPatientPanel();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Examination Events

        #region Side Panel Buttons

        private void btnMedicine_Click(object sender, EventArgs e)
        {
            new FrmMedicine().ShowDialog();
        }

        private void btnLabTest_Click(object sender, EventArgs e)
        {
            new FrmLabTest().ShowDialog();
        }

        private void btnRadiology_Click(object sender, EventArgs e)
        {
            new FrmRadiology().ShowDialog();
        }

        private void btnChronicDiseases_Click(object sender, EventArgs e)
        {
            new FrmChronicDiseases().ShowDialog();
        }

        private void btnOperativeDetails_Click(object sender, EventArgs e)
        {
            new FrmOperationDetails().ShowDialog();
        }

        private void btnSurgicalHx_Click(object sender, EventArgs e)
        {
            new FrmSurgicalHx().ShowDialog();
        }

        private void btnDrugHx_Click(object sender, EventArgs e)
        {
            new FrmDrugHx().ShowDialog();
        }

        private void btnEmgNcv_Click(object sender, EventArgs e)
        {
            new FrmEmgNcv().ShowDialog();
        }

        private void btnFamilyHx_Click(object sender, EventArgs e)
        {
            new FrmFamilyHx().ShowDialog();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            new FrmPhoto().ShowDialog();
        }

        #endregion

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            new FrmComplaints().ShowDialog();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            new FrmLightExamination().ShowDialog();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            new FrmDiagnosis().ShowDialog();
        }

        private void swVisitType_ValueChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Examination.ExaminationType = swVisitType.Value;
            ExaminationManager.UpdateExamination(Examination);
            Cursor = Cursors.Default;
        }

        private void btnSaveVisit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadExaminationFromForm(Examination);
            ExaminationManager.UpdateExamination(Examination);
            Cursor = Cursors.Default;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #endregion

        #region Methods

        private void ResetForm()
        {
            ResetPatientPanel();
            ResetExaminationPanel();
            ResetPropertiesValues();
        }

        private void ResetPropertiesValues()
        {
            Mode = ExaminationFormMode.Normal;
            Patient = null;
            Examination = null;
        }

        private void ResetPatientPanel()
        {
            EnableOrDisableControls(ExaminationFormMode.Normal);
            btnNewPatient.Text = @"New";
            btnNewPatient.Image = Resources.Add;
            errorProvider.Clear();
            ResetPatientData();
        }

        private void ResetPatientData()
        {
            txtPatientId.Text = string.Empty;
            txtPatientName.Text = string.Empty;
            txtPatientAddress.Text = string.Empty;
            txtPatientPhone.Text = string.Empty;
            txtPatientJob.Text = string.Empty;
            dtPatientBirthdate.Value = default(DateTime);
            swPatientGender.Value = true;
        }

        private void EnableOrDisableControls(ExaminationFormMode mode)
        {
            Mode = mode;

            #region Patient Panel

            txtPatientId.Enabled = mode == ExaminationFormMode.Normal;
            txtPatientName.Enabled = mode == ExaminationFormMode.Normal || mode == ExaminationFormMode.AddNewPatient ||
                                     mode == ExaminationFormMode.EditPatient;
            btnFindPatient.Enabled = mode == ExaminationFormMode.Normal;
            txtPatientAddress.Enabled = mode == ExaminationFormMode.AddNewPatient ||
                                        mode == ExaminationFormMode.EditPatient;
            txtPatientPhone.Enabled = mode == ExaminationFormMode.AddNewPatient ||
                                      mode == ExaminationFormMode.EditPatient;
            txtPatientJob.Enabled = mode == ExaminationFormMode.AddNewPatient ||
                                    mode == ExaminationFormMode.EditPatient;
            dtPatientBirthdate.Enabled = mode == ExaminationFormMode.AddNewPatient ||
                                         mode == ExaminationFormMode.EditPatient;
            swPatientGender.Enabled = mode == ExaminationFormMode.AddNewPatient ||
                                      mode == ExaminationFormMode.EditPatient;
            btnNewPatient.Enabled = mode == ExaminationFormMode.Normal || mode == ExaminationFormMode.HasPatient ||
                                    mode == ExaminationFormMode.AddNewPatient;
            btnEditPatient.Enabled = mode == ExaminationFormMode.EditPatient || mode == ExaminationFormMode.HasPatient;

            #endregion

            #region Examination Panel

            swVisitType.Enabled = mode == ExaminationFormMode.HasPatient;
            btnComplaint.Enabled = mode == ExaminationFormMode.HasPatient;
            btnExamination.Enabled = mode == ExaminationFormMode.HasPatient;
            btnDiagnosis.Enabled = mode == ExaminationFormMode.HasPatient;
            lstExaminations.Enabled = mode == ExaminationFormMode.HasPatient;
            btnSaveVisit.Enabled = mode == ExaminationFormMode.HasPatient;
            btnClearAll.Enabled = mode == ExaminationFormMode.HasPatient;

            #endregion

            #region Left Side Panel (Buttons)

            pnlLeftSideButtons.Enabled = mode == ExaminationFormMode.HasPatient;

            #endregion
        }

        private void ResetExaminationPanel()
        {
        }

        private void StartExamination(Patient patient)
        {
            ShowPatientData(patient);
            EnableOrDisableControls(ExaminationFormMode.HasPatient);
            CreateNewExaminationIfNotExistsForToday(patient.Id);
            LoadAllExaminationsForPatient(patient.Id);
        }

        private void ShowPatientData(Patient patient)
        {
            txtPatientId.Text = patient.Id;
            txtPatientName.Text = patient.Name;
            txtPatientAddress.Text = patient.Address;
            txtPatientPhone.Text = patient.Phone;
            txtPatientJob.Text = patient.Job;
            dtPatientBirthdate.Value = patient.BirthDate ?? default(DateTime);
            swPatientGender.Value = patient.Gender;
        }

        private void CreateNewExaminationIfNotExistsForToday(string patientId)
        {
            var today = DateTime.Now.Date;
            if (ExaminationManager.IsExistsExaminationForPatient(patientId, today))
                return;
            Examination = new Examination
            {
                PatientId = patientId,
                Date = today,
                ExaminationType = swVisitType.Value,
                ExaminationOfExamination = txtExamination.Text.FullTrim()
            };
            ExaminationManager.AddNewExamination(Examination);
        }

        private void LoadAllExaminationsForPatient(string patientId)
        {
            var allPatientExaminations = ExaminationManager.GetAllExaminationsForPatient(patientId).ToList();
            lstExaminations.DataSource = allPatientExaminations.OrderByDescending(examination => examination.Date)
                .Select(examination => new ListBoxVm
                {
                    Id = examination.Id,
                    DateTime = examination.Date
                }).ToList();
            lstExaminations.DisplayMember = ListBoxDisplayMember;
            lstExaminations.ValueMember = ListBoxValueMember;
            Examination = allPatientExaminations.FirstOrDefault();
        }

        private void AddNewPatient()
        {
            if (btnNewPatient.Text == @"New")
            {
                ResetPatientData();
                EnableOrDisableControls(ExaminationFormMode.AddNewPatient);
                btnNewPatient.Text = @"Save";
                btnNewPatient.Image = Resources.Save;
            }
            else
            {
                if (!txtPatientName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
                {
                    Patient = new Patient();
                    LoadPatientFromForm(Patient);
                    //TODO: validate this business
                    //Patient.Id = GetNextPatientId(PatientManager.GetLastPatientId());
                    Patient.Id = "100";
                    PatientManager.AddNewPatient(Patient);
                    btnNewPatient.Text = @"New";
                    btnNewPatient.Image = Resources.Add;
                    StartExamination(Patient);
                }
                else
                    errorProvider.SetError(txtPatientName, ValidationMsg);
            }
        }

        private void LoadPatientFromForm(Patient patient)
        {
            patient.Name = txtPatientName.Text.FullTrim();
            patient.Address = txtPatientAddress.Text.FullTrim();
            patient.Phone = txtPatientPhone.Text.FullTrim();
            patient.Job = txtPatientJob.Text.FullTrim();
            patient.BirthDate = dtPatientBirthdate.Value;
            patient.Gender = swPatientGender.Value;
        }

        private void LoadExaminationFromForm(Examination examination)
        {
            examination.ExaminationOfExamination = txtExamination.Text.FullTrim();
            examination.Date = DateTime.Now;
            examination.ExaminationType = swVisitType.Value;
        }

        private void FindPatient()
        {
            var patientId = txtPatientId.Text.FullTrim();
            var patientName = txtPatientName.Text.FullTrim();
            if (patientId.IsNullOrEmptyOrWhiteSpace() && patientName.IsNullOrEmptyOrWhiteSpace())
            {
                ShowErrorMsg("You should enter Patient ID or Name");
                return;
            }
            Patient = !patientId.IsNullOrEmptyOrWhiteSpace()
                ? PatientManager.GetPatientById(patientId)
                : PatientManager.GetPatientByName(patientName);
            if (Patient != null)
                StartExamination(Patient);
            else
                ShowErrorMsg("There's not any patient with this ID or Name");
        }

        private void EditPatient()
        {
            if (btnEditPatient.Text == @"Edit")
            {
                btnEditPatient.Text = @"Save";
                btnEditPatient.Image = Resources.Save;
                EnableOrDisableControls(ExaminationFormMode.EditPatient);
            }
            else
            {
                if (txtPatientName.Text.FullTrim().IsNullOrEmptyOrWhiteSpace())
                {
                    errorProvider.SetError(txtPatientName, ValidationMsg);
                    return;
                }
                LoadPatientFromForm(Patient);
                PatientManager.UpdatePatient(Patient);
                btnEditPatient.Text = @"Edit";
                btnEditPatient.Image = Resources.Edit;
                EnableOrDisableControls(ExaminationFormMode.HasPatient);
            }
        }

        #endregion
    }
}