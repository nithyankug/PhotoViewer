namespace photoViewer
{
    partial class pictureThumbnail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.theAlbum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // thumbnail
            // 
            this.thumbnail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbnail.ErrorImage = null;
            this.thumbnail.InitialImage = null;
            this.thumbnail.Location = new System.Drawing.Point(5, 5);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(120, 120);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 0;
            this.thumbnail.TabStop = false;
            // 
            // theAlbum
            // 
            this.theAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theAlbum.Font = new System.Drawing.Font("SketchFlow Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.theAlbum.Location = new System.Drawing.Point(5, 127);
            this.theAlbum.Name = "theAlbum";
            this.theAlbum.Size = new System.Drawing.Size(120, 21);
            this.theAlbum.TabIndex = 1;
            this.theAlbum.Text = "Album";
            this.theAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.theAlbum.Click += new System.EventHandler(this.name_Click);
            // 
            // pictureThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.theAlbum);
            this.Controls.Add(this.thumbnail);
            this.Name = "pictureThumbnail";
            this.Size = new System.Drawing.Size(130, 150);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Label theAlbum;

    }
}
