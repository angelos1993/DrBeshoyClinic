using System;
using System.Linq;
using System.Windows.Forms;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;
using static DrBeshoyClinic.Utility.Constants;
using static DrBeshoyClinic.Utility.Utility;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmAddNewChronicDisease : FrmMaster
    {
        #region Constructor

        public FrmAddNewChronicDisease()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private ChronicDiseaseManager _chronicDiseaseManager;

        private ChronicDiseaseManager ChronicDiseaseManager
            => _chronicDiseaseManager ?? (_chronicDiseaseManager = new ChronicDiseaseManager());

        #endregion

        #region Events

        private void FrmAddNewChronicDisease_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddOrDeleteChronicDisease();
            (Owner as FrmChronicDiseases)?.BindAllDiseasesToGrid();
            Close();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            SetAutoCompletionForTextBoxes();
        }

        private void SetAutoCompletionForTextBoxes()
        {
            var collection = new AutoCompleteStringCollection();
            collection.AddRange(ChronicDiseaseManager.GetAllChronicDiseases()
                .Select(chronicDisease => chronicDisease.Name).ToArray());
            SetAutoCompleteSourceForTextBox(txtDiseaseName, collection);
        }

        private void AddOrDeleteChronicDisease()
        {
            var chronicDiseasName = txtDiseaseName.Text.FullTrim();
            if (chronicDiseasName.IsNullOrEmptyOrWhiteSpace())
            {
                errorProvider.SetError(txtDiseaseName, RequiredValidationMsg);
                return;
            }
            if (radAdd.Checked)
            {
                ChronicDiseaseManager.AddNewChronicDisease(new ChronicDiseas {Name = chronicDiseasName});
            }
            else
            {
                var chronicDisease = ChronicDiseaseManager.GetChronicDiseasByName(chronicDiseasName);
                if (chronicDisease == null)
                    return;
                ChronicDiseaseManager.DeleteChronicDisease(chronicDisease);
            }
        }

        #endregion
    }
}