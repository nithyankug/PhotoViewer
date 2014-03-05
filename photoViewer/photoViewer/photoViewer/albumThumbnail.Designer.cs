namespace photoViewer
{
    partial class albumThumbnail
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.albumName = new System.Windows.Forms.Label();
            this.nbPhoto = new System.Windows.Forms.Label();
            this.deleteAlbum = new System.Windows.Forms.Button();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // albumName
            // 
            this.albumName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.albumName.Location = new System.Drawing.Point(53, 5);
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(124, 23);
            this.albumName.TabIndex = 3;
            this.albumName.Text = "label1";
            this.albumName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nbPhoto
            // 
            this.nbPhoto.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPhoto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nbPhoto.Location = new System.Drawing.Point(148, 28);
            this.nbPhoto.Name = "nbPhoto";
            this.nbPhoto.Size = new System.Drawing.Size(30, 20);
            this.nbPhoto.TabIndex = 4;
            this.nbPhoto.Text = "label1";
            this.nbPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteAlbum
            // 
            this.deleteAlbum.BackgroundImage = global::photoViewer.Properties.Resources.appbar_close;
            this.deleteAlbum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteAlbum.FlatAppearance.BorderSize = 0;
            this.deleteAlbum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAlbum.Location = new System.Drawing.Point(28, 27);
            this.deleteAlbum.Name = "deleteAlbum";
            this.deleteAlbum.Size = new System.Drawing.Size(20, 20);
            this.deleteAlbum.TabIndex = 5;
            this.deleteAlbum.UseVisualStyleBackColor = true;
            // 
            // thumbnail
            // 
            this.thumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbnail.Location = new System.Drawing.Point(3, 2);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(45, 45);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 0;
            this.thumbnail.TabStop = false;
            // 
            // albumThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.deleteAlbum);
            this.Controls.Add(this.nbPhoto);
            this.Controls.Add(this.albumName);
            this.Controls.Add(this.thumbnail);
            this.Name = "albumThumbnail";
            this.Size = new System.Drawing.Size(180, 50);
            this.Click += new System.EventHandler(this.albumThumbnail_Click);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Label albumName;
        private System.Windows.Forms.Label nbPhoto;
        private System.Windows.Forms.Button deleteAlbum;
    }
}