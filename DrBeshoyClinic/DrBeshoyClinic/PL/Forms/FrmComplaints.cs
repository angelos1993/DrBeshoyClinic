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
    public partial class FrmComplaints : FrmMaster
    {
        #region Constructor

        public FrmComplaints()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ComplaintManager _complaintManager;
        private ComplaintManager ComplaintManager => _complaintManager ?? (_complaintManager = new ComplaintManager());
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<Complaint> AllPatientComplaints { get; set; }
        private List<Complaint> TodaysComplaints { get; set; }
        private List<Complaint> NewComplaints { get; set; }
        private List<Complaint> DeletedComplaints { get; set; }
        private static DateTime Today => DateTime.Now.Date;
        private bool ShouldBind { get; set; }

        #endregion

        #region Events

        private void FrmComplaints_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FrmComplaints_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ShouldBind)
                OwnerForm.BindComplaints(TodaysComplaints.Select(complaint => complaint.Name).ToCommaSeperatedString());
        }

        private void btnAddComplaint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddComplaint();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (NewComplaints.Any())
                ComplaintManager.AddListOfComplaints(NewComplaints);
            if (DeletedComplaints.Any())
                ComplaintManager.DeleteListOfComplaints(DeletedComplaints);
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

        private void lstComplaints_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadLabTestsForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void dgvComplaints_DoubleClick(object sender, EventArgs e)
        {
            //todo: need to be tested well & should be moved into a separate function
            //todo: MUST check if the selected day is TODAY or not (if not shouldn't do anything)
            var complaintName = dgvComplaints.SelectedRows[0].Cells[0].Value.ToString();
            if (complaintName.IsNullOrEmptyOrWhiteSpace())
                return;
            var selectedComplaint = TodaysComplaints.FirstOrDefault(complaint => complaint.Name == complaintName);
            if (selectedComplaint == null)
                return;
            TodaysComplaints.Remove(selectedComplaint);
            if (NewComplaints.Contains(selectedComplaint))
                NewComplaints.Remove(selectedComplaint);
            else
                DeletedComplaints.Add(selectedComplaint);
            BindComplaintsToGrid(TodaysComplaints);
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            AllPatientComplaints = ComplaintManager.GetComplaintsForPatient(Patient.Id).ToList();
            var todaysComplaints = AllPatientComplaints.Where(complaint => complaint.Date == Today).ToList();
            TodaysComplaints = todaysComplaints.Any() ? todaysComplaints : new List<Complaint>();
            NewComplaints = DeletedComplaints = new List<Complaint>();
            BindComplaintsToListView();
            if(TodaysComplaints.Any())
                BindComplaintsToGrid(TodaysComplaints);
            SetAutoCompletionForTextBoxes();
            lstComplaints.SelectedIndex = 0;
        }

        private void AddComplaint()
        {
            var complaintName = txtComplaint.Text.FullTrim();
            if (complaintName.IsNullOrEmptyOrWhiteSpace())
            {
                errorProvider.SetError(txtComplaint, RequiredValidationMsg);
                return;
            }
            var complaint = new Complaint
            {
                Name = complaintName,
                PatientId = Patient.Id,
                Date = Today
            };
            TodaysComplaints.Add(complaint);
            if (DeletedComplaints.Contains(complaint))
                DeletedComplaints.Remove(complaint);
            else
                NewComplaints.Add(complaint);
            BindComplaintsToGrid(TodaysComplaints);
            ResetInputControls();
        }

        private void LoadLabTestsForSelectedDate()
        {
            ResetInputControls();
            var selectedItem = lstComplaints.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            List<Complaint> selectedComplaints;
            if (selectedItem.Date == Today)
            {
                selectedComplaints = TodaysComplaints;
                EnableOrDisableControls(true);
            }
            else
            {
                selectedComplaints = AllPatientComplaints.Where(complaint => complaint.Date == selectedItem.Date)
                    .ToList();
                EnableOrDisableControls(false);
            }
            BindComplaintsToGrid(selectedComplaints);
        }

        private void BindComplaintsToListView()
        {
            var lstComplaintsDataSource =
                AllPatientComplaints.OrderByDescending(complaint => complaint.Date).GroupBy(complaint => complaint.Date)
                    .Select(complaintDateGroup => new ListBoxVm {Date = complaintDateGroup.Key}).ToList();
            if (!TodaysComplaints.Any())
                lstComplaintsDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstComplaints.DataSource = lstComplaintsDataSource;
            lstComplaints.DisplayMember = ListBoxDisplayMember;
        }

        private void BindComplaintsToGrid(IEnumerable<Complaint> complaints)
        {
            dgvComplaints.DataSource = complaints.Select(complaint => new ComplaintVm
                {ComplaintName = complaint.Name}).ToList();
            if (dgvComplaints.Width > dgvComplaints.Columns.GetColumnsWidth(DataGridViewElementStates.Visible))
            {

            }
        }

        private void SetAutoCompletionForTextBoxes()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(ComplaintManager.GetAllComplaints().Select(complaint => complaint.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtComplaint, collection);
        }

        private void ResetInputControls()
        {
            txtComplaint.Clear();
            errorProvider.Clear();
        }

        private void EnableOrDisableControls(bool isEnabled)
        {
            txtComplaint.Enabled = isEnabled;
            btnAddComplaint.Enabled = isEnabled;
        }

        #endregion
    }
}