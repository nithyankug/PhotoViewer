namespace photoViewer
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
            this.albumsTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableImages = new System.Windows.Forms.TableLayoutPanel();
            this.closeWindow = new System.Windows.Forms.Button();
            this.enlargeButton = new System.Windows.Forms.Button();
            this.reduceButton = new System.Windows.Forms.Button();
            this.sizeDisplay = new System.Windows.Forms.TrackBar();
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
            this.albumsTable.Location = new System.Drawing.Point(12, 35);
            this.albumsTable.Name = "albumsTable";
            this.albumsTable.RowCount = 1;
            this.albumsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.albumsTable.Size = new System.Drawing.Size(180, 437);
            this.albumsTable.TabIndex = 12;
            this.albumsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableImages
            // 
            this.tableImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));

            this.tableImages.HorizontalScroll.Visible = false;
            this.tableImages.HorizontalScroll.Enabled = false;
            this.tableImages.VerticalScroll.Enabled = true;
            this.tableImages.VerticalScroll.Visible = true;
            this.tableImages.AutoScroll = true;
            
            this.tableImages.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tableImages.ColumnCount = 5;
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableImages.Location = new System.Drawing.Point(199, 35);
            this.tableImages.Name = "tableImages";
            this.tableImages.RowCount = 1;
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableImages.Size = new System.Drawing.Size(798, 417);
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
            this.sizeDisplay.Location = new System.Drawing.Point(824, 455);
            this.sizeDisplay.Name = "sizeDisplay";
            this.sizeDisplay.Size = new System.Drawing.Size(173, 45);
            this.sizeDisplay.TabIndex = 14;
            this.sizeDisplay.Scroll += new System.EventHandler(this.sizeDisplay_Scroll);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1008, 484);
            this.Controls.Add(this.sizeDisplay);
            this.Controls.Add(this.tableImages);
            this.Controls.Add(this.albumsTable);
            this.Controls.Add(this.closeWindow);
            this.Controls.Add(this.enlargeButton);
            this.Controls.Add(this.reduceButton);
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
    }
}

