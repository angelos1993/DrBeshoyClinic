namespace DrBeshoyClinic.PL.Forms
{
    partial class FrmPhoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstVwPhotos = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.lstPhotos = new System.Windows.Forms.ListBox();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnAddPhoto = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // lstVwPhotos
            // 
            // 
            // 
            // 
            this.lstVwPhotos.Border.Class = "ListViewBorder";
            this.lstVwPhotos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lstVwPhotos.Location = new System.Drawing.Point(11, 12);
            this.lstVwPhotos.Name = "lstVwPhotos";
            this.lstVwPhotos.Size = new System.Drawing.Size(770, 384);
            this.lstVwPhotos.TabIndex = 0;
            this.lstVwPhotos.UseCompatibleStateImageBehavior = false;
            // 
            // lstPhotos
            // 
            this.lstPhotos.FormattingEnabled = true;
            this.lstPhotos.ItemHeight = 20;
            this.lstPhotos.Location = new System.Drawing.Point(787, 12);
            this.lstPhotos.Name = "lstPhotos";
            this.lstPhotos.Size = new System.Drawing.Size(120, 384);
            this.lstPhotos.TabIndex = 52;
            this.lstPhotos.SelectedIndexChanged += new System.EventHandler(this.lstPhotos_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Image = global::DrBeshoyClinic.Properties.Resources.Exit;
            this.btnCancel.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Location = new System.Drawing.Point(545, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(130, 40);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Image = global::DrBeshoyClinic.Properties.Resources.Save;
            this.btnSave.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSave.Location = new System.Drawing.Point(409, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 53;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddPhoto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddPhoto.Image = global::DrBeshoyClinic.Properties.Resources.Add;
            this.btnAddPhoto.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnAddPhoto.Location = new System.Drawing.Point(244, 402);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(159, 40);
            this.btnAddPhoto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddPhoto.TabIndex = 56;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // FrmPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 458);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstPhotos);
            this.Controls.Add(this.lstVwPhotos);
            this.DoubleBuffered = true;
            this.Name = "FrmPhoto";
            this.Text = "Photo";
            this.Load += new System.EventHandler(this.FrmPhoto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ListViewEx lstVwPhotos;
        private System.Windows.Forms.ListBox lstPhotos;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnAddPhoto;
    }
}