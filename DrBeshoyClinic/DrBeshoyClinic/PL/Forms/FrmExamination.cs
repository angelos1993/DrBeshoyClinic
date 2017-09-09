using System;
using System.Collections.Generic;
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
using static DrBeshoyClinic.Utility.Utility;

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

        private ComplaintManager _complaintManager;
        private ComplaintManager ComplaintManager => _complaintManager ?? (_complaintManager = new ComplaintManager());
        private DiagnosisManager _diagnosisManager;
        private DiagnosisManager DiagnosisManager => _diagnosisManager ?? (_diagnosisManager = new DiagnosisManager());
        private ChronicDiseaseManager _chronicDiseaseManager;

        private ChronicDiseaseManager ChronicDiseaseManager
            => _chronicDiseaseManager ?? (_chronicDiseaseManager = new ChronicDiseaseManager());

        private SurgicalHxManager _surgicalHxManager;

        private SurgicalHxManager SurgicalHxManager
            => _surgicalHxManager ?? (_surgicalHxManager = new SurgicalHxManager());

        private DrugHxManager _drugHxManager;
        private DrugHxManager DrugHxManager => _drugHxManager ?? (_drugHxManager = new DrugHxManager());
        private FamilyHxManager _familyHxManager;
        private FamilyHxManager FamilyHxManager => _familyHxManager ?? (_familyHxManager = new FamilyHxManager());
        private List<Examination> AllPatientExaminations { get; set; }
        public ExaminationFormMode Mode { get; set; }
        public Patient Patient { get; set; }
        public Examination Examination { get; set; }
        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Events

        #region Form Events

        private void FrmExamination_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FrmExamination_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveCurrentExamination();
            Cursor = Cursors.Default;
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
            new FrmMedicine {Owner = this}.ShowDialog();
        }

        private void btnLabTest_Click(object sender, EventArgs e)
        {
            new FrmLabTest {Owner = this}.ShowDialog();
        }

        private void btnRadiology_Click(object sender, EventArgs e)
        {
            new FrmRadiology {Owner = this}.ShowDialog();
        }

        private void btnChronicDiseases_Click(object sender, EventArgs e)
        {
            new FrmChronicDiseases {Owner = this, Examination = Examination}.ShowDialog();
        }

        private void btnOperativeDetails_Click(object sender, EventArgs e)
        {
            new FrmOperationDetails {Owner = this, Diagnosis = txtDiagnosis.Text.FullTrim()}.ShowDialog();
        }

        private void btnSurgicalHx_Click(object sender, EventArgs e)
        {
            new FrmSurgicalHx {Owner = this}.ShowDialog();
        }

        private void btnDrugHx_Click(object sender, EventArgs e)
        {
            new FrmDrugHx {Owner = this}.ShowDialog();
        }

        private void btnEmgNcv_Click(object sender, EventArgs e)
        {
            new FrmEmgNcv {Owner = this}.ShowDialog();
        }

        private void btnFamilyHx_Click(object sender, EventArgs e)
        {
            new FrmFamilyHx {Owner = this}.ShowDialog();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            new FrmPhoto {Owner = this}.ShowDialog();
        }

        #endregion

        private void btnComplaint_Click(object sender, EventArgs e)
        {
            new FrmComplaints {Owner = this}.ShowDialog();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            new FrmLightExamination {Owner = this, AllPatientExaminations = AllPatientExaminations}.ShowDialog();
        }

        private void btnDiagnosis_Click(object sender, EventArgs e)
        {
            new FrmDiagnosis {Owner = this}.ShowDialog();
        }

        private void lstExaminations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = lstExaminations.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            LoadCurrentExaminationData(
                ExaminationManager.GetExaminationByPatientAndDate(Patient.Id, selectedItem.Date));
            EnableOrDisableControls(selectedItem.Date == Today
                ? ExaminationFormMode.HasPatient
                : ExaminationFormMode.HasPreviousExamination);
        }

        private void btnSaveVisit_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveCurrentExamination();
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

        private void txtPatientIdOrName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                FindPatient();
        }

        #endregion

        #endregion

        #region Methods

        private void ResetForm()
        {
            ResetPatientPanel();
            ResetExaminationPanel();
            ResetPropertiesValues();
            SetAutoCompletionForTextBoxes();
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
            txtPatientId.Clear();
            txtPatientName.Clear();
            txtPatientAddress.Clear();
            txtPatientPhone.Clear();
            txtPatientJob.Clear();
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
            btnClearPatient.Enabled = mode == ExaminationFormMode.Normal || mode == ExaminationFormMode.EditPatient ||
                                      mode == ExaminationFormMode.AddNewPatient ||
                                      mode == ExaminationFormMode.HasPatient;

            #endregion

            #region Examination Panel

            swVisitType.Enabled = mode == ExaminationFormMode.HasPatient;
            btnComplaint.Enabled = mode == ExaminationFormMode.HasPatient;
            btnExamination.Enabled = mode == ExaminationFormMode.HasPatient;
            btnDiagnosis.Enabled = mode == ExaminationFormMode.HasPatient;
            lstExaminations.Enabled = mode == ExaminationFormMode.HasPatient ||
                                      mode == ExaminationFormMode.HasPreviousExamination;
            btnSaveVisit.Enabled = mode == ExaminationFormMode.HasPatient;
            btnClearAll.Enabled = mode == ExaminationFormMode.HasPatient;

            #endregion

            #region Left Side Panel (Buttons)

            pnlLeftSideButtons.Enabled = mode == ExaminationFormMode.HasPatient;

            #endregion
        }

        private void ResetExaminationPanel()
        {
            swVisitType.Value = true;
            txtComplaints.Clear();
            txtExamination.Clear();
            txtDiagnosis.Clear();
            txtChronicDiseases.Clear();
            txtSurgicalHx.Clear();
            txtDrugHx.Clear();
            txtFamilyHx.Clear();
            if (lstExaminations.DataSource != null)
                lstExaminations.SelectedIndex = 0;
        }

        private void StartExamination(Patient patient)
        {
            ShowPatientData(patient);
            EnableOrDisableControls(ExaminationFormMode.HasPatient);
            CreateNewExaminationIfNotExistsForToday(patient.Id);
            LoadAllExaminationsForPatient(patient.Id);
            LoadCurrentExaminationData(Examination);
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
            var today = Today;
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
            AllPatientExaminations = ExaminationManager.GetAllExaminationsForPatient(patientId).ToList();
            lstExaminations.DataSource = AllPatientExaminations.OrderByDescending(examination => examination.Date)
                .Select(examination => new ListBoxVm {Date = examination.Date}).ToList();
            lstExaminations.DisplayMember = ListBoxDisplayMember;
            Examination = AllPatientExaminations.OrderByDescending(examination => examination.Date).FirstOrDefault();
        }

        private void LoadCurrentExaminationData(Examination examination)
        {
            swVisitType.Value = examination.ExaminationType;
            txtComplaints.Text =
                ComplaintManager.GetComplaintsStringByPatientAndDate(examination.PatientId, examination.Date);
            txtExamination.Text = examination.ExaminationOfExamination;
            txtDiagnosis.Text =
                DiagnosisManager.GetDiagnosisStringByPatientAndDate(examination.PatientId, examination.Date);
            txtChronicDiseases.Text = ChronicDiseaseManager.GetChronicDiseasByExaminationId(examination.Id);
            txtSurgicalHx.Text =
                SurgicalHxManager.GetSurgicalHxsForPatientByDate(examination.PatientId, examination.Date);
            txtDrugHx.Text = DrugHxManager.GetDrugHxsForPatientByDate(examination.PatientId, examination.Date);
            txtFamilyHx.Text = FamilyHxManager.GetFamilyHxsForPatientByDate(examination.PatientId, examination.Date);
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
                    Patient.Id = GetNextPatientId(PatientManager.GetLastPatientId());
                    PatientManager.AddNewPatient(Patient);
                    btnNewPatient.Text = @"New";
                    btnNewPatient.Image = Resources.Add;
                    StartExamination(Patient);
                }
                else
                {
                    errorProvider.SetError(txtPatientName, RequiredValidationMsg);
                }
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
            examination.Date = Today;
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
                    errorProvider.SetError(txtPatientName, RequiredValidationMsg);
                    return;
                }
                LoadPatientFromForm(Patient);
                PatientManager.UpdatePatient(Patient);
                btnEditPatient.Text = @"Edit";
                btnEditPatient.Image = Resources.Edit;
                EnableOrDisableControls(ExaminationFormMode.HasPatient);
            }
        }

        private void SaveCurrentExamination()
        {
            LoadExaminationFromForm(Examination);
            ExaminationManager.UpdateExamination(Examination);
        }

        private void SetAutoCompletionForTextBoxes()
        {
            SetAutoCompletionForPatientIds();
            SetAutoCompletionForPatientNames();
        }

        private void SetAutoCompletionForPatientIds()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(PatientManager.GetAllPatients().Select(patient => patient.Id).ToArray());
            SetAutoCompleteSourceForTextBox(txtPatientId, collection);
        }

        private void SetAutoCompletionForPatientNames()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(PatientManager.GetAllPatients().Select(patient => patient.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtPatientName, collection);
        }

        #region Call-Back(s)

        public void BindComplaints(string complaints)
        {
            txtComplaints.Text = complaints;
        }

        public void BindExamination(string examination)
        {
            txtExamination.Text = examination;
            Examination.ExaminationOfExamination = examination;
        }

        public void BindDiagnosis(string diagnosis)
        {
            txtDiagnosis.Text = diagnosis;
        }

        public void BindChronicDiseases(string chronicDiseases)
        {
            txtChronicDiseases.Text = chronicDiseases;
        }

        public void BindSurgicalHxes(string surgicalHxes)
        {
            txtSurgicalHx.Text = surgicalHxes;
        }

        public void BindDrugHxes(string drugHxes)
        {
            txtDrugHx.Text = drugHxes;
        }

        public void BindFamilyHxes(string familyHxes)
        {
            txtFamilyHx.Text = familyHxes;
        }

        #endregion

        #endregion
    }
}