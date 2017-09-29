using System;
using System.Windows.Forms;
using DrBeshoyClinic.Utility;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using static DrBeshoyClinic.Utility.MessageBoxUtility;
using static DrBeshoyClinic.Utility.Constants;

namespace DrBeshoyClinic.PL.Forms
{
    public partial class FrmBackupAndRestore : FrmMaster
    {
        #region Constructor

        public FrmBackupAndRestore()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        #endregion

        #region Events

        private void FrmBackupAndRestore_Load(object sender, EventArgs e)
        {
            ResetControls(false);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            BackupDatabase();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            RestoreDatabase();
        }

        private void PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Value = e.Percent;
            lblProgress.Text = $@"{e.Percent}%";
        }

        private void Backup_Complet(object sender, ServerMessageEventArgs e)
        {
            Cursor = Cursors.Default;
            ResetControls(false);
            ShowInfoMsg("Backup database completed successfully!");
            Close();
        }

        private void Restore_Complete(object sender, ServerMessageEventArgs e)
        {
            Cursor = Cursors.Default;
            ResetControls(false);
            ShowInfoMsg("Restore database completed successfully!");
            Close();
        }

        #endregion

        #region Methods

        private void BackupDatabase()
        {
            try
            {
                var folderBrowserDialog = new FolderBrowserDialog {Description = @"Select backup location"};
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return;
                ResetControls(true);
                var server = new Server(new ServerConnection(ServerName));
                var backup = new Backup {Action = BackupActionType.Database, Database = DatabaseName};
                backup.Devices.AddDevice(
                    $@"{folderBrowserDialog.SelectedPath}\{DatabaseName} - {
                            DateTime.Now.ToCustomFormattedLongDateString()
                        }.bak", DeviceType.File);
                backup.Initialize = true;
                backup.PercentComplete += PercentComplete;
                backup.Complete += Backup_Complet;
                backup.SqlBackupAsync(server);
            }
            catch
            {
                Cursor = Cursors.Default;
                ShowErrorMsg("Error, Please choose another location");
            }
        }

        private void RestoreDatabase()
        {
            try
            {
                var openFileDialog = new OpenFileDialog
                {
                    Title = @"Choose the backup file",
                    Filter = @"bak files (.bak)|*.bak",
                    Multiselect = false
                };
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                ResetControls(true);
                var server = new Server(new ServerConnection(ServerName));
                var restore = new Restore
                {
                    Database = DatabaseName,
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };
                restore.Devices.AddDevice($@"{openFileDialog.FileName}", DeviceType.File);
                restore.PercentComplete += PercentComplete;
                restore.Complete += Restore_Complete;
                restore.SqlRestoreAsync(server);
            }
            catch
            {
                Cursor = Cursors.Default;
                ShowErrorMsg("Error, choose another file");
            }
        }

        private void ResetControls(bool isVisible)
        {
            progressBar.Visible = isVisible;
            lblProgress.Visible = isVisible;
            lblProgress.Text = @"0%";
        }

        #endregion
    }
}