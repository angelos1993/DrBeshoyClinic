using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DrBeshoyClinic.Utility;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmPhotoDisplay : FrmMaster
    {
        #region Constructor

        public FrmPhotoDisplay()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public List<byte[]> Photos { get; set; }
        public int SelectedPhotoIndex { get; set; }

        #endregion

        #region Events

        private void FrmPhotoDisplay_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ShowPhoto(true);
            Cursor = Cursors.Default;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ShowPhoto(false);
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            BindToForm();
        }

        private void ShowPhoto(bool isNext)
        {
            if (isNext)
            {
                SelectedPhotoIndex++;
                if (SelectedPhotoIndex >= Photos.Count)
                    SelectedPhotoIndex = 0;
            }
            else
            {
                SelectedPhotoIndex--;
                if (SelectedPhotoIndex < 0)
                    SelectedPhotoIndex = Photos.Count - 1;
            }
            BindToForm();
        }

        private void BindToForm()
        {
            picBox.Image = Photos[SelectedPhotoIndex].ToImage();
            lblCount.Text = $@"{SelectedPhotoIndex + 1} of {Photos.Count}";
        }

        #endregion
    }
}