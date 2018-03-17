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
    public partial class FrmRadiology : FrmMaster
    {
        #region Constructor

        public FrmRadiology()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private RadiologyManager _radiologyManager;
        private RadiologyManager RadiologyManager => _radiologyManager ?? (_radiologyManager = new RadiologyManager());
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<Radiology> AllRadiologies { get; set; }
        private List<Radiology> TodaysRadiologies { get; set; }
        private List<Radiology> NewRadiologies { get; set; }
        private List<Radiology> DeletedRadiologies { get; set; }
        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Events

        private void FrmRadiology_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAddRadiology_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddRadiology();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (NewRadiologies.Any())
                RadiologyManager.AddListOfRadiologies(NewRadiologies);
            if (DeletedRadiologies.Any())
                RadiologyManager.DeleteListOfRadiologies(DeletedRadiologies);
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

        private void lstRadiologies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadRadiologiesForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void dgvRadiologies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DeleteRadiology();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            AllRadiologies = RadiologyManager.GetRadiologiesForPatient(Patient.Id).ToList();
            var todaysRadiologies = AllRadiologies.Where(radiology => radiology.Date == Today).ToList();
            TodaysRadiologies = todaysRadiologies.Any() ? todaysRadiologies : new List<Radiology>();
            NewRadiologies = new List<Radiology>();
            DeletedRadiologies = new List<Radiology>();
            BindRadiologiesToListView();
            if (TodaysRadiologies.Any())
                BindRadiologiesToGrid(TodaysRadiologies);
            SetAutoCompletionForTextBoxes();
        }

        private void BindRadiologiesToListView()
        {
            var lstRadiologiesDataSource =
                AllRadiologies.OrderByDescending(radiology => radiology.Date).GroupBy(radiology => radiology.Date)
                    .Select(radiologyDateGroup => new ListBoxVm {Date = radiologyDateGroup.Key}).ToList();
            if (!TodaysRadiologies.Any())
                lstRadiologiesDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstRadiologies.DataSource = lstRadiologiesDataSource;
            lstRadiologies.DisplayMember = ListBoxDisplayMember;
        }

        private void BindRadiologiesToGrid(IEnumerable<Radiology> radiologies)
        {
            dgvRadiologies.DataSource = radiologies.Select(radiology => new RadiologyVm
                {Name = radiology.Name, Description = radiology.Description}).ToList();
        }

        private void SetAutoCompletionForTextBoxes()
        {
            SetAutoCompletionForRadiologyNames();
            SetAutoCompletionForRadiologyDescriptions();
        }

        private void SetAutoCompletionForRadiologyNames()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(RadiologyManager.GetAllRadiologies().Select(radiology => radiology.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtRadiology, collection);
        }

        private void SetAutoCompletionForRadiologyDescriptions()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(RadiologyManager.GetAllRadiologies().Select(radiology => radiology.Description)
                .ToArray());
            SetAutoCompleteSourceForTextBox(txtRadiologyDescription, collection);
        }

        private void AddRadiology()
        {
            var radiologyName = txtRadiology.Text.FullTrim();
            var radiologyDescription = txtRadiologyDescription.Text.FullTrim();
            if (radiologyName.IsNullOrEmptyOrWhiteSpace())
            {
                errorProvider.SetError(txtRadiology, RequiredValidationMsg);
                return;
            }
            var radiology = new Radiology
            {
                Name = radiologyName,
                Description = radiologyDescription,
                PatientId = Patient.Id,
                Date = Today
            };
            TodaysRadiologies.Add(radiology);
            if (DeletedRadiologies.Contains(radiology))
                DeletedRadiologies.Remove(radiology);
            else
                NewRadiologies.Add(radiology);
            BindRadiologiesToGrid(TodaysRadiologies);
            ResetInputControls();
        }

        private void ResetInputControls()
        {
            txtRadiology.Clear();
            txtRadiologyDescription.Clear();
            errorProvider.Clear();
        }

        private void LoadRadiologiesForSelectedDate()
        {
            ResetInputControls();
            var selectedItem = lstRadiologies.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            List<Radiology> selectedRadiologies;
            if (selectedItem.Date == Today)
            {
                selectedRadiologies = TodaysRadiologies;
                EnableOrDisableControls(true);
            }
            else
            {
                selectedRadiologies = AllRadiologies.Where(radiology => radiology.Date == selectedItem.Date)
                    .Select(radiology => radiology).ToList();
                EnableOrDisableControls(false);
            }
            BindRadiologiesToGrid(selectedRadiologies);
        }

        private void EnableOrDisableControls(bool isEnabled)
        {
            txtRadiology.Enabled = isEnabled;
            txtRadiology.Enabled = isEnabled;
            btnAddRadiology.Enabled = isEnabled;
        }

        private void DeleteRadiology()
        {
            var selectedItem = lstRadiologies.SelectedItem as ListBoxVm;
            if (selectedItem == null || selectedItem.Date != Today || dgvRadiologies.SelectedRows.Count == 0)
                return;
            var selectedRadiology = TodaysRadiologies.FirstOrDefault(
                radiology => radiology.Name == dgvRadiologies.SelectedRows[0].Cells[0].Value.ToString());
            if (selectedRadiology == null)
                return;
            TodaysRadiologies.Remove(selectedRadiology);
            if (NewRadiologies.Contains(selectedRadiology))
                NewRadiologies.Remove(selectedRadiology);
            else
                DeletedRadiologies.Add(selectedRadiology);
            BindRadiologiesToGrid(TodaysRadiologies);
        }

        #endregion
    }
}