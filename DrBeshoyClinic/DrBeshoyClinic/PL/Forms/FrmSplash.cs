namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmSplash : FrmMaster
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            timer.Enabled = false;
            Hide();
            new FrmIndex().Show();
        }
    }
}