using System;
using System.Windows.Forms;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmChronicDiseases : FrmMaster
    {
        #region Constructor

        public FrmChronicDiseases()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        private void FrmChronicDiseases_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAddDiasease_Click(object sender, EventArgs e)
        {
            new FrmAddNewChronicDisease {Owner = this}.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            BindAllDiseasesToGrid();
        }

        public void BindAllDiseasesToGrid()
        {
            
        }

        #endregion
    }
}