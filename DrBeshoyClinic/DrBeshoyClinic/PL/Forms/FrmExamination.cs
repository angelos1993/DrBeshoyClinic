using System;

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

        #endregion

        #region Events

        #region Form Events

        private void FrmExamination_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Patient Events

        private void btnFindPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPatient_Click(object sender, EventArgs e)
        {

        }

        private void btnClearPatient_Click(object sender, EventArgs e)
        {

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

        private void btnAddComplaint_Click(object sender, EventArgs e)
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

        private void btnSaveVisit_Click(object sender, EventArgs e)
        {

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {

        }


        #endregion

        #endregion

        #region Methods

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}