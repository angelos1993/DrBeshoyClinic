using System.Collections.Generic;
using System.Linq;
using DrBeshoyClinic.DAL.VMs;
using Microsoft.Reporting.WinForms;
using static DrBeshoyClinic.Utility.Constants;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmRoshetta : FrmMaster
    {
        #region Constructor

        public FrmRoshetta()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public RoshettaVm RoshettaVm { get; set; }

        #endregion

        #region Events

        private void FrmRoshetta_Load(object sender, System.EventArgs e)
        {
            LoadRoshetta();
        }

        #endregion

        #region Methods

        private void LoadRoshetta()
        {
            repVwRoshetta.LocalReport.SetParameters(new List<ReportParameter>
            {
                new ReportParameter("PatientName", RoshettaVm.PatientName),
                new ReportParameter("PatientAge", RoshettaVm.PatientAge),
                new ReportParameter("Date", RoshettaVm.DateString),
                new ReportParameter("Diagnosis", RoshettaVm.Diagnosis ?? ReportParameterEmptyValue)
            });
            roshettaMedicineVmBindingSource.DataSource = RoshettaVm.MedicineDetails
                .Select(roshettaMedicineVm => new RoshettaMedicineVm
                {
                    TreatmentName = roshettaMedicineVm.TreatmentName,
                    TreatmentPeriod = $"\n{roshettaMedicineVm.TreatmentPeriod}",
                    TreatmentDescription = $"\n{roshettaMedicineVm.TreatmentDescription}"
                }).ToList();
            repVwRoshetta.RefreshReport();
        }

        #endregion
    }
}