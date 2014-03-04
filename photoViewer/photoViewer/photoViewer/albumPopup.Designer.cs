namespace photoViewer
{
    partial class albumPopup
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
            this.winName = new System.Windows.Forms.Label();
            this.fileSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.selectFolder = new System.Windows.Forms.Button();
            this.nbImg = new System.Windows.Forms.Label();
            this.imgPhoto = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.validate = new System.Windows.Forms.Button();
            this.albumName = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // winName
            // 
            this.winName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.winName.Location = new System.Drawing.Point(79, 0);
            this.winName.Name = "winName";
            this.winName.Size = new System.Drawing.Size(154, 32);
            this.winName.TabIndex = 1;
            this.winName.Text = "Add Album";
            this.winName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileSelector
            // 
            this.fileSelector.RootFolder = System.Environment.SpecialFolder.UserProfile;
            // 
            // selectFolder
            // 
            this.selectFolder.BackColor = System.Drawing.Color.Transparent;
            this.selectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowFrame;
            this.selectFolder.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowFrame;
            this.selectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFolder.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFolder.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.selectFolder.Location = new System.Drawing.Point(94, 73);
            this.selectFolder.Name = "selectFolder";
            this.selectFolder.Size = new System.Drawing.Size(121, 23);
            this.selectFolder.TabIndex = 4;
            this.selectFolder.Text = "Select Folder";
            this.selectFolder.UseVisualStyleBackColor = false;
            this.selectFolder.Click += new System.EventHandler(this.selectFolder_Click);
            // 
            // nbImg
            // 
            this.nbImg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nbImg.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbImg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.nbImg.Location = new System.Drawing.Point(46, 97);
            this.nbImg.Name = "nbImg";
            this.nbImg.Size = new System.Drawing.Size(45, 32);
            this.nbImg.TabIndex = 5;
            this.nbImg.Text = "x 0";
            this.nbImg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgPhoto
            // 
            this.imgPhoto.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.imgPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgPhoto.BackgroundImage = global::photoViewer.Properties.Resources.appbar_camera;
            this.imgPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgPhoto.CausesValidation = false;
            this.imgPhoto.Enabled = false;
            this.imgPhoto.FlatAppearance.BorderSize = 0;
            this.imgPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imgPhoto.Location = new System.Drawing.Point(2, 87);
            this.imgPhoto.Name = "imgPhoto";
            this.imgPhoto.Size = new System.Drawing.Size(50, 50);
            this.imgPhoto.TabIndex = 6;
            this.imgPhoto.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackgroundImage = global::photoViewer.Properties.Resources.appbar_close;
            this.cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancel.FlatAppearance.BorderSize = 0;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Location = new System.Drawing.Point(228, 97);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(30, 30);
            this.cancel.TabIndex = 3;
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // validate
            // 
            this.validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validate.BackgroundImage = global::photoViewer.Properties.Resources.appbar_check;
            this.validate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.validate.FlatAppearance.BorderSize = 0;
            this.validate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.validate.Location = new System.Drawing.Point(260, 97);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(30, 30);
            this.validate.TabIndex = 2;
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // albumName
            // 
            this.albumName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.albumName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName.Location = new System.Drawing.Point(12, 35);
            this.albumName.MaxLength = 15;
            this.albumName.Multiline = false;
            this.albumName.Name = "albumName";
            this.albumName.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.albumName.Size = new System.Drawing.Size(274, 28);
            this.albumName.TabIndex = 0;
            this.albumName.Text = "";
            // 
            // albumPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(298, 133);
            this.ControlBox = false;
            this.Controls.Add(this.imgPhoto);
            this.Controls.Add(this.nbImg);
            this.Controls.Add(this.selectFolder);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.winName);
            this.Controls.Add(this.albumName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "albumPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "New Album";
            this.TransparencyKey = System.Drawing.SystemColors.InactiveCaption;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainWindow_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label winName;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.FolderBrowserDialog fileSelector;
        private System.Windows.Forms.Button selectFolder;
        private System.Windows.Forms.Label nbImg;
        private System.Windows.Forms.Button imgPhoto;
        private System.Windows.Forms.RichTextBox albumName;
    }
}