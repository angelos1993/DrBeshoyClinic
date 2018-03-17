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
    public partial class FrmDiagnosis : FrmMaster
    {
        #region Constructor

        public FrmDiagnosis()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private DiagnosisManager _diagnosisManager;
        private DiagnosisManager DiagnosisManager => _diagnosisManager ?? (_diagnosisManager = new DiagnosisManager());
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<Diagnosi> AllPatientDiagnosis { get; set; }
        private List<Diagnosi> TodaysDiagnosis { get; set; }
        private List<Diagnosi> NewDiagnosis { get; set; }
        private List<Diagnosi> DeletedDiagnosis { get; set; }
        private static DateTime Today => DateTime.Now.Date;
        private bool ShouldBind { get; set; }

        #endregion

        #region Events

        private void FrmDiagnosis_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FrmDiagnosis_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ShouldBind)
                OwnerForm.BindDiagnosis(TodaysDiagnosis.Select(diagnosi => diagnosi.Name).ToCommaSeperatedString());
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddDiagnosis();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (NewDiagnosis.Any())
                DiagnosisManager.AddListOfDiagnosis(NewDiagnosis);
            if (DeletedDiagnosis.Any())
                DiagnosisManager.DeleteListOfDiagnosis(DeletedDiagnosis);
            ShouldBind = true;
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

        private void lstDiagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadDiagnosisForSelectedDate();
            Cursor = Cursors.Default;
        }
        
        private void dgvDiagnosis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DeleteDiagnisi();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            AllPatientDiagnosis = DiagnosisManager.GetDiagnosisForPatient(Patient.Id).ToList();
            var todaysDiagnosis = AllPatientDiagnosis.Where(diagnosi => diagnosi.Date == Today).ToList();
            TodaysDiagnosis = todaysDiagnosis.Any() ? todaysDiagnosis : new List<Diagnosi>();
            NewDiagnosis = new List<Diagnosi>();
            DeletedDiagnosis = new List<Diagnosi>();
            BindDiagnosisToListView();
            if (TodaysDiagnosis.Any())
                BindDiagnosisToGrid(TodaysDiagnosis);
            SetAutoCompletionForTextBoxes();
            lstDiagnosis.SelectedIndex = 0;
        }

        private void AddDiagnosis()
        {
            var diagnosiName = txtDiagnosis.Text.FullTrim();
            if (diagnosiName.IsNullOrEmptyOrWhiteSpace())
            {
                errorProvider.SetError(txtDiagnosis, RequiredValidationMsg);
                return;
            }
            var diagnosi = new Diagnosi
            {
                Name = diagnosiName,
                PatientId = Patient.Id,
                Date = Today
            };
            TodaysDiagnosis.Add(diagnosi);
            if (DeletedDiagnosis.Contains(diagnosi))
                DeletedDiagnosis.Remove(diagnosi);
            else
                NewDiagnosis.Add(diagnosi);
            BindDiagnosisToGrid(TodaysDiagnosis);
            ResetInputControls();
        }

        private void LoadDiagnosisForSelectedDate()
        {
            ResetInputControls();
            var selectedItem = lstDiagnosis.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            List<Diagnosi> selecteDiagnosis;
            if (selectedItem.Date == Today)
            {
                selecteDiagnosis = TodaysDiagnosis;
                EnableOrDisableControls(true);
            }
            else
            {
                selecteDiagnosis = AllPatientDiagnosis.Where(diagnosi => diagnosi.Date == selectedItem.Date).ToList();
                EnableOrDisableControls(false);
            }
            BindDiagnosisToGrid(selecteDiagnosis);
        }

        private void BindDiagnosisToListView()
        {
            var lstDiagnosisDataSource =
                AllPatientDiagnosis.OrderByDescending(diagnosi => diagnosi.Date).GroupBy(diagnosi => diagnosi.Date)
                    .Select(diagnosiDateGroup => new ListBoxVm {Date = diagnosiDateGroup.Key}).ToList();
            if (!TodaysDiagnosis.Any())
                lstDiagnosisDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstDiagnosis.DataSource = lstDiagnosisDataSource;
            lstDiagnosis.DisplayMember = ListBoxDisplayMember;
        }

        private void BindDiagnosisToGrid(IEnumerable<Diagnosi> diagnosis)
        {
            dgvDiagnosis.DataSource = diagnosis.Select(diagnosi => new DiagnosiVm {DiagnosisName = diagnosi.Name})
                .ToList();
        }

        private void SetAutoCompletionForTextBoxes()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(DiagnosisManager.GetAllDiagnosis().Select(diagnosi => diagnosi.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtDiagnosis, collection);
        }

        private void ResetInputControls()
        {
            txtDiagnosis.Clear();
            errorProvider.Clear();
        }

        private void EnableOrDisableControls(bool isEnabled)
        {
            txtDiagnosis.Enabled = isEnabled;
            btnAddDiagnosis.Enabled = isEnabled;
        }

        private void DeleteDiagnisi()
        {
            var selectedItem = lstDiagnosis.SelectedItem as ListBoxVm;
            if (selectedItem == null || selectedItem.Date != Today || dgvDiagnosis.SelectedRows.Count == 0)
                return;
            var selectedDiagnosi = TodaysDiagnosis.FirstOrDefault(
                diagnosi => diagnosi.Name == dgvDiagnosis.SelectedRows[0].Cells[0].Value.ToString());
            if (selectedDiagnosi == null)
                return;
            TodaysDiagnosis.Remove(selectedDiagnosi);
            if (NewDiagnosis.Contains(selectedDiagnosi))
                NewDiagnosis.Remove(selectedDiagnosi);
            else
                DeletedDiagnosis.Add(selectedDiagnosi);
            BindDiagnosisToGrid(TodaysDiagnosis);
        }

        #endregion
    }
}