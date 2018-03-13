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
    public partial class FrmLabTest : FrmMaster
    {
        #region Constructor

        public FrmLabTest()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private LabTestManager _labTestManager;
        private LabTestManager LabTestManager => _labTestManager ?? (_labTestManager = new LabTestManager());
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<LabTest> AllLabTests { get; set; }
        private List<LabTest> TodaysLabTests { get; set; }
        private List<LabTest> NewLabTests { get; set; }
        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Events

        private void FrmLabTest_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (NewLabTests.Any())
                LabTestManager.AddListOfLabTests(NewLabTests);
            Close();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstLabTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadLabTestsForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void btnAddLabTest_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddLabTest();
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            AllLabTests = LabTestManager.GetAllLabTestsForPatient(Patient.Id).ToList();
            var todaysLabTests = AllLabTests.Where(labTest => labTest.Date == Today).ToList();
            TodaysLabTests = todaysLabTests.Any() ? todaysLabTests : new List<LabTest>();
            NewLabTests = new List<LabTest>();
            BindLabTestsToListView();
            if (TodaysLabTests.Any())
                BindLabTestsToGrid(TodaysLabTests);
            SetAutoCompletionForTextBoxes();
        }

        private void LoadLabTestsForSelectedDate()
        {
            ResetInputControls();
            var selectedItem = lstLabTests.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            List<LabTest> selectedLabTests;
            if (selectedItem.Date == Today)
            {
                selectedLabTests = TodaysLabTests;
                EnableOrDisableControls(true);
            }
            else
            {
                selectedLabTests = AllLabTests.Where(labTest => labTest.Date == selectedItem.Date).ToList();
                EnableOrDisableControls(false);
            }
            BindLabTestsToGrid(selectedLabTests);
        }

        private void BindLabTestsToGrid(IEnumerable<LabTest> labTests)
        {
            var labTestsList = labTests as IList<LabTest> ?? labTests.ToList();
            dgvLabTests.DataSource = labTestsList.Select(labTest => new LabTestVm
                {TestName = labTest.TestName, TestResult = labTest.TestResult}).ToList();
            dgvLabTests.AutoSizeColumnsMode = labTestsList.Any()
                ? DataGridViewAutoSizeColumnsMode.DisplayedCells
                : DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BindLabTestsToListView()
        {
            var lstLabTestsDataSource =
                AllLabTests.OrderByDescending(labTest => labTest.Date).GroupBy(labTest => labTest.Date)
                    .Select(labTestDateGroup => new ListBoxVm {Date = labTestDateGroup.Key}).ToList();
            if (!TodaysLabTests.Any())
                lstLabTestsDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstLabTests.DataSource = lstLabTestsDataSource;
            lstLabTests.DisplayMember = ListBoxDisplayMember;
        }

        private void AddLabTest()
        {
            var testName = txtTestName.Text.FullTrim();
            var testResult = txtTestResult.Text.FullTrim();
            if (testName.IsNullOrEmptyOrWhiteSpace())
            {
                errorProvider.SetError(txtTestName, RequiredValidationMsg);
                return;
            }
            var labTest = new LabTest
            {
                TestName = testName,
                TestResult = testResult,
                PatientId = Patient.Id,
                Date = Today
            };
            TodaysLabTests.Add(labTest);
            NewLabTests.Add(labTest);
            BindLabTestsToGrid(TodaysLabTests);
            ResetInputControls();
        }

        private void ResetInputControls()
        {
            txtTestName.Clear();
            txtTestResult.Clear();
            errorProvider.Clear();
        }

        private void EnableOrDisableControls(bool isEnabled)
        {
            txtTestName.Enabled = isEnabled;
            txtTestResult.Enabled = isEnabled;
            btnAddLabTest.Enabled = isEnabled;
        }

        private void SetAutoCompletionForTextBoxes()
        {
            SetAutoCompletionForTestNames();
            SetAutoCompletionForTestResults();
        }

        private void SetAutoCompletionForTestResults()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(LabTestManager.GetAllLabTests().Select(labTest => labTest.TestName).ToArray());
            SetAutoCompleteSourceForTextBox(txtTestName, collection);
        }

        private void SetAutoCompletionForTestNames()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(LabTestManager.GetAllLabTests().Select(labTest => labTest.TestResult).ToArray());
            SetAutoCompleteSourceForTextBox(txtTestResult, collection);
        }

        #endregion
    }
}