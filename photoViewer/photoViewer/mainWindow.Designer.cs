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
            this.reduceButton = new System.Windows.Forms.Button();
            this.enlargeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.albumsTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableImages = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // reduceButton
            // 
            this.reduceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reduceButton.Location = new System.Drawing.Point(890, -4);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(26, 23);
            this.reduceButton.TabIndex = 7;
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // enlargeButton
            // 
            this.enlargeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enlargeButton.Location = new System.Drawing.Point(918, -4);
            this.enlargeButton.Name = "enlargeButton";
            this.enlargeButton.Size = new System.Drawing.Size(26, 23);
            this.enlargeButton.TabIndex = 8;
            this.enlargeButton.UseVisualStyleBackColor = true;
            this.enlargeButton.Click += new System.EventHandler(this.enlargeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(946, -4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // albumsTable
            // 
            this.albumsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.albumsTable.BackColor = System.Drawing.SystemColors.Window;
            this.albumsTable.ColumnCount = 1;
            this.albumsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.albumsTable.Location = new System.Drawing.Point(12, 35);
            this.albumsTable.Name = "albumsTable";
            this.albumsTable.RowCount = 1;
            this.albumsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.albumsTable.Size = new System.Drawing.Size(180, 437);
            this.albumsTable.TabIndex = 12;
            this.albumsTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableImages
            // 
            this.tableImages.AllowDrop = true;
            this.tableImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableImages.BackColor = System.Drawing.SystemColors.Window;
            this.tableImages.ColumnCount = 1;
            this.tableImages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableImages.Location = new System.Drawing.Point(199, 35);
            this.tableImages.Name = "tableImages";
            this.tableImages.RowCount = 8;
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableImages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableImages.Size = new System.Drawing.Size(773, 437);
            this.tableImages.TabIndex = 13;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(984, 484);
            this.Controls.Add(this.tableImages);
            this.Controls.Add(this.albumsTable);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.enlargeButton);
            this.Controls.Add(this.reduceButton);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainWindow_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.Button enlargeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TableLayoutPanel albumsTable;
        private System.Windows.Forms.TableLayoutPanel tableImages;
    }
}

