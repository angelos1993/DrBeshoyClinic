using DrBeshoyClinic.DAL.Model;

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

        }

        #endregion

        #region Methods

        #endregion
    }
}