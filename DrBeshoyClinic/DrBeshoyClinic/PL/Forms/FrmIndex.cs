using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmIndex : Office2007Form
    {
        #region Constructor

        public FrmIndex()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        private void btnExamination_Click(object sender, EventArgs e)
        {
            new FrmExamination().ShowDialog();
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            new FrmDailyReport().ShowDialog();
        }

        private void FrmIndex_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}