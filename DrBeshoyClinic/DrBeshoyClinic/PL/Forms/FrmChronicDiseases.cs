using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.Utility;

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

        private ChronicDiseaseManager _chronicDiseaseManager;

        private ChronicDiseaseManager ChronicDiseaseManager
            => _chronicDiseaseManager ?? (_chronicDiseaseManager = new ChronicDiseaseManager());

        private ExaminationChronicDiseaseManager _examinationChronicDiseaseManager;

        private ExaminationChronicDiseaseManager ExaminationChronicDiseaseManager =>
            _examinationChronicDiseaseManager ?? (_examinationChronicDiseaseManager =
                new ExaminationChronicDiseaseManager());

        public Examination Examination { get; set; }
        private List<ChronicDiseas> AllChronicDiseases { get; set; }
        private List<ExaminationChronicDisease> SelectedChronicDiseases { get; set; }

        #endregion

        #region Events

        private void FrmChronicDiseases_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FrmChronicDiseases_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SelectedChronicDiseases == null || !SelectedChronicDiseases.Any())
                return;
            (Owner as FrmExamination)?.BindChronicDiseases(AllChronicDiseases
                .Where(chronicDisease => SelectedChronicDiseases
                    .Select(selectedChronicDisease => selectedChronicDisease.ChronicDiseaseId)
                    .Contains(chronicDisease.Id)).Select(chronicDisease => chronicDisease.Name)
                .ToCommaSeperatedString());
        }

        private void btnAddDiasease_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            new FrmAddNewChronicDisease {Owner = this}.ShowDialog();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveExaminationChronicDisease();
            Close();
            Cursor = Cursors.Default;
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
            AllChronicDiseases = ChronicDiseaseManager.GetAllChronicDiseases().ToList();
            SelectedChronicDiseases = ExaminationChronicDiseaseManager
                .GetChronicDiseasesForExamination(Examination.Id).ToList();
            dgvChronicDiseases.Rows.Clear();
            dgvChronicDiseases.AutoGenerateColumns = false;
            foreach (var diseas in AllChronicDiseases)
                dgvChronicDiseases.Rows.Add(SelectedChronicDiseases.Select(chronicDisease
                    => chronicDisease.ChronicDiseaseId).Contains(diseas.Id), diseas.Name, SelectedChronicDiseases
                    .Where(chronicDisease => chronicDisease.ChronicDiseaseId == diseas.Id)
                    .Select(chronicDisease => chronicDisease.Notes).FirstOrDefault());
        }

        public void SaveExaminationChronicDisease()
        {
            SelectedChronicDiseases.Clear();
            foreach (DataGridViewRow row in dgvChronicDiseases.Rows)
            {
                if (!Convert.ToBoolean(row.Cells[0].Value))
                    continue;
                SelectedChronicDiseases.Add(new ExaminationChronicDisease
                {
                    ChronicDiseaseId = AllChronicDiseases.Where(chronicDisease =>
                            chronicDisease.Name == row.Cells[1].Value.ToString())
                        .Select(chronicDisease => chronicDisease.Id).FirstOrDefault(),
                    ExaminationId = Examination.Id,
                    Notes = row.Cells[2].Value?.ToString()
                });
            }
            if (SelectedChronicDiseases.Any())
                ExaminationChronicDiseaseManager.AddListOfChronicDiseases(SelectedChronicDiseases);
        }

        #endregion
    }
}