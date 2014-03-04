namespace photoViewer
{
    partial class slideShow
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
            this.components = new System.ComponentModel.Container();
            this.timerInter = new System.Windows.Forms.NumericUpDown();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureCounter = new System.Windows.Forms.Label();
            this.pictureNameLabel = new System.Windows.Forms.Label();
            this.albumNameLabel = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.closeSlideShow = new System.Windows.Forms.Button();
            this.imageSlide = new System.Windows.Forms.PictureBox();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timerInter)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // timerInter
            // 
            this.timerInter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timerInter.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.timerInter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerInter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerInter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.timerInter.Location = new System.Drawing.Point(616, 11);
            this.timerInter.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timerInter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timerInter.Name = "timerInter";
            this.timerInter.Size = new System.Drawing.Size(73, 23);
            this.timerInter.TabIndex = 9;
            this.timerInter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerInter.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.timerInter.ValueChanged += new System.EventHandler(this.timerInter_ValueChanged);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Controls.Add(this.pictureCounter);
            this.panel.Controls.Add(this.pictureNameLabel);
            this.panel.Controls.Add(this.albumNameLabel);
            this.panel.Controls.Add(this.previous);
            this.panel.Controls.Add(this.next);
            this.panel.Controls.Add(this.playButton);
            this.panel.Controls.Add(this.timerInter);
            this.panel.Location = new System.Drawing.Point(12, 353);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(692, 43);
            this.panel.TabIndex = 10;
            // 
            // pictureCounter
            // 
            this.pictureCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureCounter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureCounter.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pictureCounter.Location = new System.Drawing.Point(4, 3);
            this.pictureCounter.Name = "pictureCounter";
            this.pictureCounter.Size = new System.Drawing.Size(52, 36);
            this.pictureCounter.TabIndex = 12;
            this.pictureCounter.Text = "200";
            this.pictureCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureNameLabel
            // 
            this.pictureNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureNameLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pictureNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pictureNameLabel.Location = new System.Drawing.Point(58, 21);
            this.pictureNameLabel.Name = "pictureNameLabel";
            this.pictureNameLabel.Size = new System.Drawing.Size(200, 18);
            this.pictureNameLabel.TabIndex = 13;
            this.pictureNameLabel.Text = "pictureName";
            // 
            // albumNameLabel
            // 
            this.albumNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.albumNameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.albumNameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.albumNameLabel.Location = new System.Drawing.Point(58, 7);
            this.albumNameLabel.Name = "albumNameLabel";
            this.albumNameLabel.Size = new System.Drawing.Size(200, 23);
            this.albumNameLabel.TabIndex = 12;
            this.albumNameLabel.Text = "albumName";
            // 
            // previous
            // 
            this.previous.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previous.BackColor = System.Drawing.Color.Transparent;
            this.previous.BackgroundImage = global::photoViewer.Properties.Resources.appbar_chevron_left;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previous.FlatAppearance.BorderSize = 0;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.Location = new System.Drawing.Point(289, 3);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(35, 35);
            this.previous.TabIndex = 11;
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.BackgroundImage = global::photoViewer.Properties.Resources.appbar_chevron_right;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(371, 3);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(35, 35);
            this.next.TabIndex = 10;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // playButton
            // 
            this.playButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImage = global::photoViewer.Properties.Resources.appbar_control_play;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Location = new System.Drawing.Point(330, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(35, 35);
            this.playButton.TabIndex = 2;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // closeSlideShow
            // 
            this.closeSlideShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeSlideShow.BackgroundImage = global::photoViewer.Properties.Resources.appbar_close;
            this.closeSlideShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeSlideShow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeSlideShow.FlatAppearance.BorderSize = 0;
            this.closeSlideShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeSlideShow.Location = new System.Drawing.Point(668, 14);
            this.closeSlideShow.Name = "closeSlideShow";
            this.closeSlideShow.Size = new System.Drawing.Size(35, 35);
            this.closeSlideShow.TabIndex = 1;
            this.closeSlideShow.UseVisualStyleBackColor = true;
            this.closeSlideShow.Click += new System.EventHandler(this.closeSlideShow_Click);
            // 
            // imageSlide
            // 
            this.imageSlide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageSlide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imageSlide.Location = new System.Drawing.Point(12, 13);
            this.imageSlide.Name = "imageSlide";
            this.imageSlide.Size = new System.Drawing.Size(693, 334);
            this.imageSlide.TabIndex = 0;
            this.imageSlide.TabStop = false;
            // 
            // slideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.closeSlideShow;
            this.ClientSize = new System.Drawing.Size(717, 408);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.closeSlideShow);
            this.Controls.Add(this.imageSlide);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "slideShow";
            this.Text = "slideShow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.slideShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timerInter)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imageSlide;
        private System.Windows.Forms.Button closeSlideShow;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.NumericUpDown timerInter;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label pictureNameLabel;
        private System.Windows.Forms.Label albumNameLabel;
        private System.Windows.Forms.Label pictureCounter;
    }
}