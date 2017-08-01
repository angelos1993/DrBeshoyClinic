namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmSplash : FrmMaster
    {
        #region Constructor

        public FrmSplash()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        private void timer_Tick(object sender, System.EventArgs e)
        {
            timer.Enabled = false;
            Hide();
            new FrmIndex().Show();
        }

        #endregion
    }
}