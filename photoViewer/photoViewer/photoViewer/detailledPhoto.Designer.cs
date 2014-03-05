namespace photoViewer
{
    partial class detailledPhoto
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.photoView = new System.Windows.Forms.PictureBox();
            this.commentLabel = new System.Windows.Forms.Label();
            this.fieldComment = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.fieldDate = new System.Windows.Forms.TextBox();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.fieldRating = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.fieldCatergory = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.closeView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.photoView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.closeView);
            this.splitContainer.Panel2.Controls.Add(this.commentLabel);
            this.splitContainer.Panel2.Controls.Add(this.fieldComment);
            this.splitContainer.Panel2.Controls.Add(this.dateLabel);
            this.splitContainer.Panel2.Controls.Add(this.fieldDate);
            this.splitContainer.Panel2.Controls.Add(this.ratingLabel);
            this.splitContainer.Panel2.Controls.Add(this.fieldRating);
            this.splitContainer.Panel2.Controls.Add(this.categoryLabel);
            this.splitContainer.Panel2.Controls.Add(this.fieldCatergory);
            this.splitContainer.Panel2.Controls.Add(this.nameLabel);
            this.splitContainer.Panel2.Controls.Add(this.fileName);
            this.splitContainer.Size = new System.Drawing.Size(784, 401);
            this.splitContainer.SplitterDistance = 508;
            this.splitContainer.TabIndex = 0;
            // 
            // photoView
            // 
            this.photoView.Location = new System.Drawing.Point(3, 12);
            this.photoView.Name = "photoView";
            this.photoView.Size = new System.Drawing.Size(505, 377);
            this.photoView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoView.TabIndex = 0;
            this.photoView.TabStop = false;
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.commentLabel.Location = new System.Drawing.Point(6, 155);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(58, 15);
            this.commentLabel.TabIndex = 9;
            this.commentLabel.Text = "Comment";
            this.commentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fieldComment
            // 
            this.fieldComment.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fieldComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldComment.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldComment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fieldComment.Location = new System.Drawing.Point(84, 156);
            this.fieldComment.Multiline = true;
            this.fieldComment.Name = "fieldComment";
            this.fieldComment.Size = new System.Drawing.Size(162, 181);
            this.fieldComment.TabIndex = 8;
            this.fieldComment.Text = "basicText";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.dateLabel.Location = new System.Drawing.Point(32, 129);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(32, 15);
            this.dateLabel.TabIndex = 7;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fieldDate
            // 
            this.fieldDate.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fieldDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fieldDate.Location = new System.Drawing.Point(85, 130);
            this.fieldDate.Name = "fieldDate";
            this.fieldDate.Size = new System.Drawing.Size(162, 15);
            this.fieldDate.TabIndex = 6;
            this.fieldDate.Text = "basicText";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratingLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ratingLabel.Location = new System.Drawing.Point(23, 103);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(41, 15);
            this.ratingLabel.TabIndex = 5;
            this.ratingLabel.Text = "Rating";
            this.ratingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fieldRating
            // 
            this.fieldRating.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fieldRating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldRating.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldRating.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fieldRating.Location = new System.Drawing.Point(85, 104);
            this.fieldRating.Name = "fieldRating";
            this.fieldRating.Size = new System.Drawing.Size(162, 15);
            this.fieldRating.TabIndex = 4;
            this.fieldRating.Text = "basicText";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.categoryLabel.Location = new System.Drawing.Point(9, 77);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(55, 15);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fieldCatergory
            // 
            this.fieldCatergory.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fieldCatergory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldCatergory.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldCatergory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fieldCatergory.Location = new System.Drawing.Point(85, 78);
            this.fieldCatergory.Name = "fieldCatergory";
            this.fieldCatergory.Size = new System.Drawing.Size(162, 15);
            this.fieldCatergory.TabIndex = 2;
            this.fieldCatergory.Text = "basicText";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.nameLabel.Location = new System.Drawing.Point(25, 51);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 15);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileName
            // 
            this.fileName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.fileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileName.Location = new System.Drawing.Point(85, 52);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(162, 15);
            this.fileName.TabIndex = 0;
            this.fileName.Text = "basicText";
            // 
            // closeView
            // 
            this.closeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeView.BackgroundImage = global::photoViewer.Properties.Resources.appbar_close;
            this.closeView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeView.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeView.FlatAppearance.BorderSize = 0;
            this.closeView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeView.Location = new System.Drawing.Point(229, 6);
            this.closeView.Name = "closeView";
            this.closeView.Size = new System.Drawing.Size(35, 35);
            this.closeView.TabIndex = 10;
            this.closeView.UseVisualStyleBackColor = true;
            this.closeView.Click += new System.EventHandler(this.closeView_Click);
            // 
            // detailledPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(784, 401);
            this.Controls.Add(this.splitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::photoViewer.Properties.Resources.logoPV;
            this.Name = "detailledPhoto";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "detailledPhoto";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.photoView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox photoView;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.TextBox fieldComment;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox fieldDate;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.TextBox fieldRating;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox fieldCatergory;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button closeView;
    }
}