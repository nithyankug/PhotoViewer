﻿namespace photoViewer
{
    partial class mainWindow
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.albumsTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableImages = new System.Windows.Forms.TableLayoutPanel();
            this.closeWindow = new System.Windows.Forms.Button();
            this.enlargeButton = new System.Windows.Forms.Button();
            this.reduceButton = new System.Windows.Forms.Button();
            this.sizeDisplay = new System.Windows.Forms.TrackBar();
            this.addAlbumButton = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.sizeIndicator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // albumsTable
            // 
            this.albumsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.albumsTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.albumsTable.ColumnCount = 1;
            this.albumsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.albumsTable.Location = new System.Drawing.Point(12, 25);
            this.albumsTable.Name = "albumsTable";
            this.albumsTable.RowCount = 1;
            this.albumsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.albumsTable.Size = new System.Drawing.Size(180, 443);
            this.albumsTable.TabIndex = 12;
            this.albumsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableImages
            // 
            this.tableImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableImages.AutoScroll = true;
            this.tableImages.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableImages.ColumnCount = 5;
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.Location = new System.Drawing.Point(199, 25);
            this.tableImages.Name = "tableImages";
            this.tableImages.RowCount = 1;
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableImages.Size = new System.Drawing.Size(798, 443);
            this.tableImages.TabIndex = 1;
            this.tableImages.Paint += new System.Windows.Forms.PaintEventHandler(this.tableImages_Paint);
            // 
            // closeWindow
            // 
            this.closeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeWindow.Location = new System.Drawing.Point(970, -4);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(26, 23);
            this.closeWindow.TabIndex = 9;
            this.closeWindow.UseVisualStyleBackColor = true;
            this.closeWindow.Click += new System.EventHandler(this.closeWindow_Click);
            // 
            // enlargeButton
            // 
            this.enlargeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enlargeButton.Location = new System.Drawing.Point(942, -4);
            this.enlargeButton.Name = "enlargeButton";
            this.enlargeButton.Size = new System.Drawing.Size(26, 23);
            this.enlargeButton.TabIndex = 8;
            this.enlargeButton.UseVisualStyleBackColor = true;
            this.enlargeButton.Click += new System.EventHandler(this.enlargeButton_Click);
            // 
            // reduceButton
            // 
            this.reduceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reduceButton.Location = new System.Drawing.Point(914, -4);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(26, 23);
            this.reduceButton.TabIndex = 7;
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // sizeDisplay
            // 
            this.sizeDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeDisplay.Location = new System.Drawing.Point(824, 471);
            this.sizeDisplay.Maximum = 3;
            this.sizeDisplay.Minimum = 1;
            this.sizeDisplay.Name = "sizeDisplay";
            this.sizeDisplay.Size = new System.Drawing.Size(173, 45);
            this.sizeDisplay.TabIndex = 14;
            this.sizeDisplay.Value = 1;
            this.sizeDisplay.Scroll += new System.EventHandler(this.sizeDisplay_Scroll);
            // 
            // addAlbumButton
            // 
            this.addAlbumButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAlbumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAlbumButton.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.addAlbumButton.Location = new System.Drawing.Point(12, 471);
            this.addAlbumButton.Name = "addAlbumButton";
            this.addAlbumButton.Size = new System.Drawing.Size(42, 23);
            this.addAlbumButton.TabIndex = 15;
            this.addAlbumButton.UseVisualStyleBackColor = true;
            this.addAlbumButton.Click += new System.EventHandler(this.addAlbumButton_Click);
            // 
            // refresh
            // 
            this.refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.refresh.Location = new System.Drawing.Point(150, 471);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(42, 23);
            this.refresh.TabIndex = 16;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // sizeIndicator
            // 
            this.sizeIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sizeIndicator.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeIndicator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sizeIndicator.Location = new System.Drawing.Point(796, 476);
            this.sizeIndicator.Name = "sizeIndicator";
            this.sizeIndicator.Size = new System.Drawing.Size(34, 23);
            this.sizeIndicator.TabIndex = 17;
            this.sizeIndicator.Click += new System.EventHandler(this.sizeIndicator_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1008, 500);
            this.Controls.Add(this.sizeIndicator);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.addAlbumButton);
            this.Controls.Add(this.sizeDisplay);
            this.Controls.Add(this.tableImages);
            this.Controls.Add(this.albumsTable);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.enlargeButton);
            this.Controls.Add(this.reduceButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainWindow_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.sizeDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel albumsTable;
        private System.Windows.Forms.TableLayoutPanel tableImages;
        private System.Windows.Forms.Button closeWindow;
        private System.Windows.Forms.Button enlargeButton;
        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.TrackBar sizeDisplay;
        private System.Windows.Forms.Button addAlbumButton;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label sizeIndicator;
    }
}

