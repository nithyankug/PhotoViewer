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
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.albumName = new System.Windows.Forms.Label();
            this.nbPhoto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // thumbnail
            // 
            this.thumbnail.Location = new System.Drawing.Point(3, 2);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(45, 45);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 0;
            this.thumbnail.TabStop = false;
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
            // albumThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
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
    }
}