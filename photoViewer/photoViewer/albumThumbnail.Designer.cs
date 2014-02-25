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
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
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
            this.albumName = new System.Windows.Forms.TextBox();
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
            this.albumName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.albumName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.albumName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumName.Location = new System.Drawing.Point(55, 4);
            this.albumName.Multiline = true;
            this.albumName.Name = "albumName";
            this.albumName.Size = new System.Drawing.Size(122, 43);
            this.albumName.TabIndex = 1;
            this.albumName.TabStop = false;
            this.albumName.Text = "AlbumName";
            this.albumName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // albumThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.albumName);
            this.Controls.Add(this.thumbnail);
            this.Name = "albumThumbnail";
            this.Size = new System.Drawing.Size(180, 50);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.TextBox albumName;
    }
}
