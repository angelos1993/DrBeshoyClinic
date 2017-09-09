using System;
using System.Collections.Generic;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.DAL.Model;

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
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<Operation> AllPatientOperations { get; set; }
        private Operation CurrentOperation { get; set; }
        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Events

        private void FrmOperationDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPostOperativeTreatment_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPostOperativeInstruction_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstOperations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Methods

        #endregion
    }
}