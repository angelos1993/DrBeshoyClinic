using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DrBeshoyClinic.BLL;
using DrBeshoyClinic.DAL.Model;
using DrBeshoyClinic.DAL.VMs;
using DrBeshoyClinic.Utility;
using static DrBeshoyClinic.Utility.Constants;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmPhoto : FrmMaster
    {
        #region Constructor

        public FrmPhoto()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private PhotoManager _photoManager;
        private PhotoManager PhotoManager => _photoManager ?? (_photoManager = new PhotoManager());
        private FrmExamination OwnerForm => Owner as FrmExamination;
        private Patient Patient => OwnerForm.Patient;
        private List<Photo> AllPatientPhotos { get; set; }
        private List<Photo> TodaysPhotos { get; set; }
        private List<Photo> NewPhotos { get; set; }
        private static DateTime Today => DateTime.Now.Date;

        #endregion

        #region Events

        private void FrmPhoto_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            AddPhoto();
            Cursor = Cursors.Default;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            SaveNewPhotos();
            Close();
            Cursor = Cursors.Default;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lstPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            LoadPhotosForSelectedDate();
            Cursor = Cursors.Default;
        }

        private void lstVwPhotos_DoubleClick(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (lstVwPhotos.SelectedItems.Count > 0)
            {
                SaveNewPhotos();
                SetCurrentPatientPhotos();
                ShowLargeImage();
            }
            Cursor = Cursors.Default;
        }

        #endregion

        #region Methods

        private void ResetForm()
        {
            SetCurrentPatientPhotos();
            BindPhotosToListView();
        }

        private void BindPhotosToListView()
        {
            var lstPhotosDataSource =
                AllPatientPhotos.OrderByDescending(photo => photo.Date).GroupBy(photo => photo.Date)
                    .Select(photoDateGroup => new ListBoxVm {Date = photoDateGroup.Key}).ToList();
            if (!TodaysPhotos.Any())
                lstPhotosDataSource.Insert(0, new ListBoxVm {Date = Today});
            lstPhotos.DataSource = lstPhotosDataSource;
            lstPhotos.DisplayMember = ListBoxDisplayMember;
        }

        private void BindPhotosToForm(IEnumerable<Photo> photos)
        {
            lstVwPhotos.Items.Clear();
            var imageList = new ImageList {ImageSize = new Size(ImageWidth, ImageHeight)};
            photos?.ToList().ForEach(photo => imageList.Images.Add(photo.Photo1.ToImage()));
            lstVwPhotos.View = View.LargeIcon;
            lstVwPhotos.LargeImageList = imageList;
            for (var i = 0; i < imageList.Images.Count; i++)
                lstVwPhotos.Items.Add(string.Empty, i);
        }

        private void LoadPhotosForSelectedDate()
        {
            var selectedItem = lstPhotos.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            btnAddPhoto.Enabled = selectedItem.Date == Today;
            BindPhotosToForm(selectedItem.Date == Today
                ? TodaysPhotos
                : AllPatientPhotos.Where(photo => photo.Date == selectedItem.Date).ToList());
        }

        private void AddPhoto()
        {
            var openFileDialog = new OpenFileDialog
            {
                Title = OpenFileDialogTitleForImages,
                Filter = AllImageFiles,
                Multiselect = true
            };
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;
            foreach (var fileName in openFileDialog.FileNames)
            {
                var photo = new Photo
                {
                    Date = Today,
                    PatientId = Patient.Id,
                    Photo1 = File.ReadAllBytes(fileName)
                };
                TodaysPhotos.Add(photo);
                NewPhotos.Add(photo);
            }
            BindPhotosToForm(TodaysPhotos);
        }

        private void ShowLargeImage()
        {
            var selectedItem = lstPhotos.SelectedItem as ListBoxVm;
            if (selectedItem == null)
                return;
            new FrmPhotoDisplay
            {
                SelectedPhotoIndex = lstVwPhotos.SelectedItems[0].ImageIndex,
                Photos = AllPatientPhotos.Where(photo => photo.Date == selectedItem.Date)
                    .Select(photo => photo.Photo1).ToList()
            }.ShowDialog();
        }

        private void SaveNewPhotos()
        {
            if (NewPhotos.Any())
                PhotoManager.AddListOfPhotos(NewPhotos);
        }

        private void SetCurrentPatientPhotos()
        {
            AllPatientPhotos = PhotoManager.GetAllPhotosForPatient(Patient.Id).ToList();
            var todaysPhotos = AllPatientPhotos.Where(photo => photo.Date == Today).ToList();
            TodaysPhotos = todaysPhotos.Any() ? todaysPhotos : new List<Photo>();
            NewPhotos = new List<Photo>();
        }

        #endregion
    }
}