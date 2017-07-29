using DevComponents.DotNetBar;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmIndex : Office2007Form
    {
        public FrmIndex()
        {
            InitializeComponent();
        }

        private void btnExamination_Click(object sender, System.EventArgs e)
        {
            new FrmExamination().ShowDialog();
        }

        private void btnDailyReport_Click(object sender, System.EventArgs e)
        {
            new FrmDailyReport().ShowDialog();
        }

        private void FrmIndex_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}