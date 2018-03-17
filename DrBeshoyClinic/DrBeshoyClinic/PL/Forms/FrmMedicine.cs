using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.DAL.VMs;
using DrBeshoyClinic.Utility;
using static DrBeshoyClinic.Utility.Constants;
using static DrBeshoyClinic.Utility.Utility;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmMedicine : FrmMaster
    {
        #region Constructor

        public FrmMedicine()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private MedicineManager _medicineManager;

        private MedicineManager MedicineManager => _medicineManager ?? (_medicineManager = new MedicineManager());
        private MedicineDetailsManager _medicineDetailsManager;

        private MedicineDetailsManager MedicineDetailsManager
            => _medicineDetailsManager ?? (_medicineDetailsManager = new MedicineDetailsManager());

        private TreatmentManager _treatmentManager;
        private TreatmentManager TreatmentManager => _treatmentManager ?? (_treatmentManager = new TreatmentManager());
        private TreatmentPeriodManager _treatmentPeriodManager;

        private TreatmentPeriodManager TreatmentPeriodManager
            => _treatmentPeriodManager ?? (_treatmentPeriodManager = new TreatmentPeriodManager());

        private TreatmentDescriptionManager _treatmentDescriptionManager;

        private TreatmentDescriptionManager TreatmentDescriptionManager
            => _treatmentDescriptionManager ?? (_treatmentDescriptionManager = new TreatmentDescriptionManager());

        private DiagnosisManager _diagnosisManager;
        private DiagnosisManager DiagnosisManager => _diagnosisManager ?? (_diagnosisManager = new DiagnosisManager());

        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private Medicine CurrentMedicine { get; set; }
        private List<Medicine> AllPatientMedicines { get; set; }
        private List<MedicineDetail> AllPatientMedicineDetails { get; set; }
        private List<MedicineDetail> NewMedicineDetails { get; set; }
        private List<MedicineDetail> DeletedMedicineDetails { get; set; }
        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Events

        private void FrmMedicine_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddMedicineDetail();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveMedicineDetails();
            Cursor = Cursors.Default;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveMedicineDetails();
            var medicineDate = (lstMedicines.SelectedItem as ListBoxVm)?.Date ?? default(DateTime);
            new FrmRoshetta
            {
                RoshettaVm = new RoshettaVm
                {
                    PatientName = Patient.Name,
                    PatientBirthDate = Patient.BirthDate,
                    Diagnosis = DiagnosisManager.GetDiagnosisStringByPatientAndDate(Patient.Id, medicineDate),
                    Date = medicineDate,
                    MedicineDetails = GetMedicineDetailsFromGrid()
                }
            }.ShowDialog();
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

        private void lstMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadMedicinesForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void dgvTreatments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DeleteMedicineDetail();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            ResetInputControls();
            CurrentMedicine = MedicineManager.CreateNewMedicineForPatientIfNotExistsForToday(Patient.Id);
            AllPatientMedicines = MedicineManager.GetAllMedicinesForPatient(Patient.Id).ToList();
            AllPatientMedicineDetails = MedicineDetailsManager.GetMedicineDetailsByPatientId(Patient.Id);
            NewMedicineDetails = new List<MedicineDetail>();
            DeletedMedicineDetails = new List<MedicineDetail>();
            BindMedicinesToListView();
            BindMedicinesToGrid(CurrentMedicine.MedicineDetails);
            SetAutoCompletionForTextBoxes();
        }

        private void LoadMedicinesForSelectedDate()
        {
            ResetInputControls();
            var selectedItem = lstMedicines.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            List<MedicineDetail> selectedMedicines;
            if (selectedItem.Date == Today)
            {
                selectedMedicines = CurrentMedicine.MedicineDetails.ToList();
                EnableOrDisableControls(true);
            }
            else
            {
                selectedMedicines = AllPatientMedicineDetails.Where(medicineDetail
                    => medicineDetail.MedicineId == AllPatientMedicines
                           .FirstOrDefault(medicine => medicine.Date == selectedItem.Date)?.Id).ToList();
                EnableOrDisableControls(false);
            }
            BindMedicinesToGrid(selectedMedicines);
        }

        private void AddMedicineDetail()
        {
            var treatmentName = txtTreatment.Text.FullTrim();
            if (treatmentName.IsNullOrEmptyOrWhiteSpace())
            {
                errorProvider.SetError(txtTreatment, RequiredValidationMsg);
                return;
            }
            var medicineDetail = new MedicineDetail
            {
                MedicineId = CurrentMedicine.Id,
                TreatmentId = TreatmentManager.GetTreatmentIdByName(treatmentName),
                TreatmentPeriodId = TreatmentPeriodManager
                    .GetTreatmentPeriodIdByDescription(txtTreatmentPeriod.Text.FullTrim()),
                TreatmentDescriptionId = TreatmentDescriptionManager
                    .GetTreatmentDescriptionIdByDescription(txtTreatmentDescription.Text.FullTrim())
            };
            CurrentMedicine.MedicineDetails.Add(medicineDetail);
            if (DeletedMedicineDetails.Contains(medicineDetail))
                DeletedMedicineDetails.Remove(medicineDetail);
            else
                NewMedicineDetails.Add(medicineDetail);
            BindMedicinesToGrid(CurrentMedicine.MedicineDetails);
            ResetInputControls();
        }

        private void SaveMedicineDetails()
        {
            if (NewMedicineDetails.Any())
                MedicineDetailsManager.AddListOfMedicineDetails(NewMedicineDetails);
            if (DeletedMedicineDetails.Any())
                MedicineDetailsManager.DeleteListOfMedicineDetails(DeletedMedicineDetails);
            NewMedicineDetails.Clear();
            DeletedMedicineDetails.Clear();
        }

        private void BindMedicinesToListView()
        {
            lstMedicines.DataSource = AllPatientMedicines.OrderByDescending(medicine => medicine.Date)
                .GroupBy(medicine => medicine.Date)
                .Select(medicineDateGroup => new ListBoxVm {Date = medicineDateGroup.Key}).ToList();
            lstMedicines.DisplayMember = ListBoxDisplayMember;
        }

        private void BindMedicinesToGrid(IEnumerable<MedicineDetail> medicineDetails)
        {
            dgvTreatments.DataSource = medicineDetails.Select(medicineDetail => new MedicineVm
            {
                TreatmentName = TreatmentManager.GetTreatmentNameById(medicineDetail.TreatmentId),
                Period = TreatmentPeriodManager.GetPeriodDescriptionById(medicineDetail.TreatmentPeriodId),
                Description = TreatmentDescriptionManager.GetDescriptionById(medicineDetail.TreatmentDescriptionId)
            }).ToList();
        }

        private void ResetInputControls()
        {
            txtTreatment.Clear();
            txtTreatmentDescription.Clear();
            txtTreatmentPeriod.Clear();
            errorProvider.Clear();
        }

        private void EnableOrDisableControls(bool isEnabled)
        {
            txtTreatment.Enabled = isEnabled;
            txtTreatmentPeriod.Enabled = isEnabled;
            txtTreatmentDescription.Enabled = isEnabled;
            btnAddMedicine.Enabled = isEnabled;
        }

        private void SetAutoCompletionForTextBoxes()
        {
            SetAutoCompletionForTreatments();
            SetAutoCompletionForTreatmentPeriods();
            SetAutoCompletionForTreatmentDescriptions();
        }

        private void SetAutoCompletionForTreatments()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(TreatmentManager.GetAllTreatments().Select(treatment => treatment.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtTreatment, collection);
        }

        private void SetAutoCompletionForTreatmentPeriods()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(TreatmentPeriodManager.GetAllTreatmentPeriods()
                .Select(treatmentPeriod => treatmentPeriod.Description).ToArray());
            SetAutoCompleteSourceForTextBox(txtTreatmentPeriod, collection);
        }

        private void SetAutoCompletionForTreatmentDescriptions()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(TreatmentDescriptionManager.GetAllTreatmentDescriptions()
                .Select(treatmentDescription => treatmentDescription.Description).ToArray());
            SetAutoCompleteSourceForTextBox(txtTreatmentDescription, collection);
        }

        private List<RoshettaMedicineVm> GetMedicineDetailsFromGrid()
        {
            return (from DataGridViewRow row in dgvTreatments.Rows
                select new RoshettaMedicineVm
                {
                    TreatmentName = row.Cells[0].Value.ToString(),
                    TreatmentPeriod = row.Cells[1].Value.ToString(),
                    TreatmentDescription = row.Cells[2].Value.ToString()
                }).ToList();
        }

        private void DeleteMedicineDetail()
        {
            var selectedItem = lstMedicines.SelectedItem as ListBoxVm;
            if (selectedItem == null || selectedItem.Date != Today || dgvTreatments.SelectedRows.Count == 0)
                return;
            var selectedMedicineDetail = CurrentMedicine.MedicineDetails.FirstOrDefault(medicineDetail
                => medicineDetail.TreatmentId == TreatmentManager
                       .GetTreatmentIdByName(dgvTreatments.SelectedRows[0].Cells[0].Value.ToString()));
            if (selectedMedicineDetail == null)
                return;
            CurrentMedicine.MedicineDetails.Remove(selectedMedicineDetail);
            if (NewMedicineDetails.Contains(selectedMedicineDetail))
                NewMedicineDetails.Remove(selectedMedicineDetail);
            else
                DeletedMedicineDetails.Add(selectedMedicineDetail);
            BindMedicinesToGrid(CurrentMedicine.MedicineDetails);
        }

        #endregion
    }
}