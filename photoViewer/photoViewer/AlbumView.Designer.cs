﻿namespace photoViewer
{
    partial class AlbumView
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
            this.thumbnail.ErrorImage = null;
            this.thumbnail.InitialImage = null;
            this.thumbnail.Location = new System.Drawing.Point(3, 3);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(144, 117);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 0;
            this.thumbnail.TabStop = false;
            // 
            // theAlbum
            // 
            this.theAlbum.AutoSize = true;
            this.theAlbum.Location = new System.Drawing.Point(4, 127);
            this.theAlbum.Name = "theAlbum";
            this.theAlbum.Size = new System.Drawing.Size(36, 13);
            this.theAlbum.TabIndex = 1;
            this.theAlbum.Text = "Album";
            this.theAlbum.Click += new System.EventHandler(this.name_Click);
            // 
            // AlbumView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.theAlbum);
            this.Controls.Add(this.thumbnail);
            this.Name = "AlbumView";
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Label theAlbum;

    }
}
