using System.Linq;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.DAL.VMs;

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

        public Medicine Medicine { get; set; }

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
            //TODO: need to be tested well
            roshettaMedicineVmBindingSource.DataSource = Medicine.MedicineDetails
                .Select(medicineDetail => new RoshettaMedicineVm
                {
                    TreatmentName = medicineDetail.Treatment.Name,
                    TreatmentPeriod = medicineDetail.TreatmentPeriod.Description,
                    TreatmentDescription = medicineDetail.TreatmentDescription.Description
                }).ToList();
        }

        #endregion
    }
}