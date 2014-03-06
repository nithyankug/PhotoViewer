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
            this.theAlbum = new System.Windows.Forms.Label();
            this.photoView = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // theAlbum
            // 
            this.theAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.theAlbum.Font = new System.Drawing.Font("SketchFlow Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.theAlbum.Location = new System.Drawing.Point(5, 107);
            this.theAlbum.Name = "theAlbum";
            this.theAlbum.Size = new System.Drawing.Size(140, 21);
            this.theAlbum.TabIndex = 1;
            this.theAlbum.Text = "Album";
            this.theAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.theAlbum.Click += new System.EventHandler(this.name_Click);
            // 
            // photoView
            // 
            this.photoView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.photoView.BackColor = System.Drawing.Color.Transparent;
            this.photoView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoView.FlatAppearance.BorderSize = 0;
            this.photoView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.photoView.Location = new System.Drawing.Point(5, 5);
            this.photoView.Name = "photoView";
            this.photoView.Size = new System.Drawing.Size(140, 100);
            this.photoView.TabIndex = 3;
            this.photoView.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ControlDark;
            this.deleteButton.BackgroundImage = global::photoViewer.Properties.Resources.appbar_close;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(7, 7);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(20, 20);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // pictureThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.photoView);
            this.Controls.Add(this.theAlbum);
            this.Name = "pictureThumbnail";
            this.Size = new System.Drawing.Size(150, 130);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label theAlbum;
        public System.Windows.Forms.Button photoView;
        public System.Windows.Forms.Button deleteButton;

    }
}
