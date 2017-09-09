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
    public partial class FrmOperationDetails : FrmMaster
    {
        #region Constructor

        public FrmOperationDetails()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private OperationManager _operationManager;
        private OperationManager OperationManager => _operationManager ?? (_operationManager = new OperationManager());
        private PostOperativeTreatmentManager _postOperativeTreatmentManager;

        private PostOperativeTreatmentManager PostOperativeTreatmentManager
            => _postOperativeTreatmentManager ?? (_postOperativeTreatmentManager = new PostOperativeTreatmentManager());

        private PostOperativeInstructionManager _postOperativeInstructionManager;

        private PostOperativeInstructionManager PostOperativeInstructionManager
            => _postOperativeInstructionManager ?? (_postOperativeInstructionManager = new PostOperativeInstructionManager());
        
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<Operation> AllPatientOperations { get; set; }
        private Operation CurrentOperation { get; set; }
        private static DateTime Today => DateTime.Now.Date;
        public string Diagnosis { get; set; }

        #endregion

        #region Events

        private void FrmOperationDetails_Load(object sender, EventArgs e)
        {
            BindPatientDataToPanel();
            ResetForm();
        }

        private void btnAddPostOperativeTreatment_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddPostOperativeTreatment();
            Cursor = Cursors.Default;
        }

        private void btnAddPostOperativeInstruction_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddPostOperativeInstruction();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            OperationManager.AddOperation(CurrentOperation);
            PostOperativeTreatmentManager.AddListOfPostOperativeTreatments(CurrentOperation.Id,
                CurrentOperation.PostOperativeTreatments.ToList());
            PostOperativeInstructionManager.AddListOfPostOperativeInstructions(CurrentOperation.Id,
                CurrentOperation.PostOperativeInstructions.ToList());
            Close();
            Cursor = Cursors.Default;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ResetForm();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadOperationsForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void lstOperations_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadOperationFromForm();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void BindPatientDataToPanel()
        {
            txtPatientId.Text = Patient.Id;
            txtPatientName.Text = Patient.Name;
            dtPatientBirthdate.Value = Patient.BirthDate ?? default(DateTime);
            swPatientGender.Value = Patient.Gender;
            txtDiagnosis.Text = Diagnosis;
            txtPatientJob.Text = Patient.Job;
            txtPatientAddress.Text = Patient.Address;
            txtPatientPhone.Text = Patient.Phone;
        }

        private void ResetForm()
        {
            AllPatientOperations = OperationManager.GetAllOperationsForPatient(Patient.Id).ToList();
            var currentOperation = AllPatientOperations.FirstOrDefault(operation => operation.Date == Today);
            CurrentOperation = currentOperation ?? new Operation();
            BindOperationsToListView();
            ShowOperationData(CurrentOperation);
            SetAutoCompletionForTextBoxes();
        }

        private void BindOperationsToListView()
        {
            var lstOperationsDataSource =
                AllPatientOperations.OrderByDescending(operation => operation.Date).GroupBy(operation => operation.Date)
                    .Select(operationDateGroup => new ListBoxVm {Date = operationDateGroup.Key}).ToList();
            if (AllPatientOperations.All(operation => operation.Date != Today))
                lstOperationsDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstOperations.DataSource = lstOperationsDataSource;
            lstOperations.DisplayMember = ListBoxDisplayMember;
        }

        private void ShowOperationData(Operation operation)
        {
            txtFuturePlan.Text = operation.FuturePlan;
            txtOperativeDetails.Text = operation.OperativeDetails;
            txtApproach.Text = operation.Approach;
            txtAnesthesiologist.Text = operation.Anesthesiologist;
            txtAnesthesia.Text = operation.Anesthesia;
            txtPosition.Text = operation.Position;
            txtAntibiotic.Text = operation.Antibiotic;
            txtBloodLoss.Text = operation.BloodLoss;
            txtImplantUsed.Text = operation.ImplantUsed;
            txtImplantCompany.Text = operation.ImplantCompany;
            numStart.Value = operation.Start;
            numEnd.Value = operation.End;
            numPressure.Value = operation.Pressure;
            chkCultureAndSensitivity.Checked = operation.IsCultureAndSensitivity;
            chkBiopsy.Checked = operation.IsBiopsy;
            txtNurse.Text = operation.Nurse;
            txtAssistant1.Text = operation.Assisstant1;
            txtAssistant2.Text = operation.Assisstant2;
            txtSurgeon.Text = operation.Surgion;
            txtNotes.Text = operation.Notes;
            BindPostOperativeTreatmentsToGrid(operation.PostOperativeTreatments);
            BindPostOperativeInstructionsToGrid(operation.PostOperativeInstructions);
        }

        private void SetAutoCompletionForTextBoxes()
        {
            //throw new NotImplementedException();
        }

        private void BindPostOperativeTreatmentsToGrid(IEnumerable<PostOperativeTreatment> postOperativeTreatments)
        {
            grdPostOperativeTreatments.DataSource = postOperativeTreatments.Select(postOperativeTreatment
                => new PostOperativeTreatmentVm {Description = postOperativeTreatment.Description}).ToList();
        }

        private void BindPostOperativeInstructionsToGrid(
            IEnumerable<PostOperativeInstruction> postOperativeInstructions)
        {
            grdPostOperativeInstructions.DataSource = postOperativeInstructions.Select(postOperativeInstruction
                => new PostOperativeInstructionVm {Description = postOperativeInstruction.Description}).ToList();
        }

        private void LoadOperationsForSelectedDate()
        {
            ResetInputControls();
            var selectedItem = lstOperations.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            Operation selectedOperation;
            if (selectedItem.Date == Today)
            {
                selectedOperation = CurrentOperation;
                EnableOrDisableControls(true);
            }
            else
            {
                selectedOperation =
                    AllPatientOperations.FirstOrDefault(operation => operation.Date == selectedItem.Date);
                EnableOrDisableControls(false);
            }
            ShowOperationData(selectedOperation);
        }

        private void ResetInputControls()
        {
            txtPostOperativeTreatment.Clear();
            txtPostOperativeInstruction.Clear();
        }

        private void AddPostOperativeTreatment()
        {
            CurrentOperation.PostOperativeTreatments.Add(
                new PostOperativeTreatment {Description = txtPostOperativeTreatment.Text.FullTrim()});
            BindPostOperativeTreatmentsToGrid(CurrentOperation.PostOperativeTreatments);
        }

        private void AddPostOperativeInstruction()
        {
            CurrentOperation.PostOperativeInstructions.Add(
                new PostOperativeInstruction {Description = txtPostOperativeInstruction.Text.FullTrim()});
            BindPostOperativeInstructionsToGrid(CurrentOperation.PostOperativeInstructions);
        }

        private void EnableOrDisableControls(bool isEnabled)
        {
            txtFuturePlan.Enabled = isEnabled;
            txtOperativeDetails.Enabled = isEnabled;
            txtApproach.Enabled = isEnabled;
            txtAnesthesiologist.Enabled = isEnabled;
            txtAnesthesia.Enabled = isEnabled;
            txtPosition.Enabled = isEnabled;
            txtAntibiotic.Enabled = isEnabled;
            txtBloodLoss.Enabled = isEnabled;
            txtImplantUsed.Enabled = isEnabled;
            txtImplantCompany.Enabled = isEnabled;
            grpPnlPostOperativeTreatment.Enabled = isEnabled;
            grpPnlPostOperativeInstructions.Enabled = isEnabled;
            grpPnlTourniquet.Enabled = isEnabled;
            grpPnlSpecimen.Enabled = isEnabled;
            grpPnlAssistants.Enabled = isEnabled;
        }

        private void LoadOperationFromForm()
        {
            CurrentOperation = new Operation
            {
                PatientId = Patient.Id,
                Date = Today,
                FuturePlan = txtFuturePlan.Text.FullTrim(),
                OperativeDetails = txtOperativeDetails.Text.FullTrim(),
                Approach = txtApproach.Text.FullTrim(),
                Anesthesiologist = txtAnesthesiologist.Text.FullTrim(),
                Anesthesia = txtAnesthesia.Text.FullTrim(),
                Position = txtPosition.Text.FullTrim(),
                Antibiotic = txtAntibiotic.Text.FullTrim(),
                BloodLoss = txtBloodLoss.Text.FullTrim(),
                ImplantUsed = txtImplantUsed.Text.FullTrim(),
                ImplantCompany = txtImplantCompany.Text.FullTrim(),
                Start = numStart.Value,
                End = numEnd.Value,
                Pressure = numPressure.Value,
                IsCultureAndSensitivity = chkCultureAndSensitivity.Checked,
                IsBiopsy = chkBiopsy.Checked,
                Nurse = txtNurse.Text.FullTrim(),
                Assisstant1 = txtAssistant1.Text.FullTrim(),
                Assisstant2 = txtAssistant2.Text.FullTrim(),
                Surgion = txtSurgeon.Text.FullTrim(),
                Notes = txtNotes.Text.FullTrim(),
                PostOperativeInstructions = GetPostOperativeInstructionsFromGrid(),
                PostOperativeTreatments = GetPostOperativeTreatmentsFromGrid()
            };
        }

        private List<PostOperativeInstruction> GetPostOperativeInstructionsFromGrid()
        {
            return (from DataGridViewRow row in grdPostOperativeInstructions.Rows
                select new PostOperativeInstruction {Description = row.Cells[0].Value.ToString()}).ToList();
        }

        private List<PostOperativeTreatment> GetPostOperativeTreatmentsFromGrid()
        {
            return (from DataGridViewRow row in grdPostOperativeTreatments.Rows
                select new PostOperativeTreatment {Description = row.Cells[0].Value.ToString()}).ToList();
        }

        #endregion
    }
}