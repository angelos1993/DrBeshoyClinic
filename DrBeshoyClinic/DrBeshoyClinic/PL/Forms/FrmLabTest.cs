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
        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Events

        private void FrmLabTest_Load(object sender, EventArgs e)
        {
            AllLabTests = LabTestManager.GetAllLabTestsForPatient(Patient.Id).ToList();
            var todaysLabTests = AllLabTests.Where(labTest => labTest.Date == Today).ToList();
            TodaysLabTests = todaysLabTests.Any() ? todaysLabTests : new List<LabTest>();
            BindLabTestsToListView();
            if (TodaysLabTests.Any())
                BindLabTestsToGrid(TodaysLabTests);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (TodaysLabTests.Any())
                LabTestManager.AddListOfLabTests(TodaysLabTests);
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

        private void LoadLabTestsForSelectedDate()
        {
            ResetInputControls();
            var selectedItem = lstLabTests.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            List<LabTest> selectedLabTests;
            if (selectedItem.DateTime == Today)
            {
                selectedLabTests = TodaysLabTests;
                EnableOrDisableControls(true);
            }
            else
            {
                selectedLabTests = AllLabTests
                    .Where(labTest => labTest.PatientId == Patient.Id && labTest.Date == selectedItem.DateTime)
                    .Select(labTest => labTest).ToList();
                EnableOrDisableControls(false);
            }
            BindLabTestsToGrid(selectedLabTests);
        }

        private void BindLabTestsToGrid(IEnumerable<LabTest> labTests)
        {
            grdLabTests.DataSource = labTests.Select(labTest => new LabTestVm
                { TestName = labTest.TestName, TestResult = labTest.TestResult }).ToList();
        }

        private void BindLabTestsToListView()
        {
            var lstLabTestsDataSource = AllLabTests.OrderByDescending(labTest => labTest.Date)
                .Select(labTest => new ListBoxVm {Id = labTest.Id, DateTime = labTest.Date}).ToList();
            if (!TodaysLabTests.Any())
                lstLabTestsDataSource.Insert(0, new ListBoxVm {Id = 0, DateTime = Today});
            lstLabTests.DataSource = lstLabTestsDataSource;
            lstLabTests.DisplayMember = ListBoxDisplayMember;
            lstLabTests.ValueMember = ListBoxValueMember;
        }

        private void AddLabTest()
        {
            var testName = txtTestName.Text.FullTrim();
            var testResult = txtTestResult.Text.FullTrim();
            if (testName.IsNullOrEmptyOrWhiteSpace())
            {
                errorProvider.SetError(txtTestName, ValidationMsg);
                return;
            }
            TodaysLabTests.Add(new LabTest
            {
                TestName = testName,
                TestResult = testResult,
                PatientId = Patient.Id,
                Date = Today
            });
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
            grdLabTests.Enabled = isEnabled;
        }
        #endregion
    }
}