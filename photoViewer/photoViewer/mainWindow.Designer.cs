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
            this.reduceButton = new System.Windows.Forms.Button();
            this.enlargeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.delAlbButton = new photoViewer.displayModeButton();
            this.addAlbButton = new photoViewer.displayModeButton();
            this.viewThreeButton = new photoViewer.displayModeButton();
            this.viewTwoButton = new photoViewer.displayModeButton();
            this.viewOneButton = new photoViewer.displayModeButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.albumsList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // reduceButton
            // 
            this.reduceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reduceButton.Location = new System.Drawing.Point(702, -4);
            this.reduceButton.Name = "reduceButton";
            this.reduceButton.Size = new System.Drawing.Size(26, 23);
            this.reduceButton.TabIndex = 7;
            this.reduceButton.UseVisualStyleBackColor = true;
            this.reduceButton.Click += new System.EventHandler(this.reduceButton_Click);
            // 
            // enlargeButton
            // 
            this.enlargeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enlargeButton.Location = new System.Drawing.Point(730, -4);
            this.enlargeButton.Name = "enlargeButton";
            this.enlargeButton.Size = new System.Drawing.Size(26, 23);
            this.enlargeButton.TabIndex = 8;
            this.enlargeButton.UseVisualStyleBackColor = true;
            this.enlargeButton.Click += new System.EventHandler(this.enlargeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(758, -4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // delAlbButton
            // 
            this.delAlbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delAlbButton.Location = new System.Drawing.Point(100, 445);
            this.delAlbButton.Name = "delAlbButton";
            this.delAlbButton.Size = new System.Drawing.Size(46, 46);
            this.delAlbButton.TabIndex = 6;
            // 
            // addAlbButton
            // 
            this.addAlbButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAlbButton.Location = new System.Drawing.Point(48, 445);
            this.addAlbButton.Name = "addAlbButton";
            this.addAlbButton.Size = new System.Drawing.Size(46, 46);
            this.addAlbButton.TabIndex = 5;
            // 
            // viewThreeButton
            // 
            this.viewThreeButton.Location = new System.Drawing.Point(302, 24);
            this.viewThreeButton.Name = "viewThreeButton";
            this.viewThreeButton.Size = new System.Drawing.Size(46, 28);
            this.viewThreeButton.TabIndex = 4;
            // 
            // viewTwoButton
            // 
            this.viewTwoButton.Location = new System.Drawing.Point(250, 24);
            this.viewTwoButton.Name = "viewTwoButton";
            this.viewTwoButton.Size = new System.Drawing.Size(46, 28);
            this.viewTwoButton.TabIndex = 3;
            // 
            // viewOneButton
            // 
            this.viewOneButton.Location = new System.Drawing.Point(198, 24);
            this.viewOneButton.Name = "viewOneButton";
            this.viewOneButton.Size = new System.Drawing.Size(46, 28);
            this.viewOneButton.TabIndex = 2;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(198, 59);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(586, 380);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // albumsList
            // 
            this.albumsList.Location = new System.Drawing.Point(12, 58);
            this.albumsList.Name = "albumsList";
            this.albumsList.Size = new System.Drawing.Size(182, 381);
            this.albumsList.TabIndex = 10;
            this.albumsList.UseCompatibleStateImageBehavior = false;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.albumsList);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.enlargeButton);
            this.Controls.Add(this.reduceButton);
            this.Controls.Add(this.delAlbButton);
            this.Controls.Add(this.addAlbButton);
            this.Controls.Add(this.viewThreeButton);
            this.Controls.Add(this.viewTwoButton);
            this.Controls.Add(this.viewOneButton);
            this.Name = "mainWindow";
            this.Text = "mainWindow";
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainWindow_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private displayModeButton viewOneButton;
        private displayModeButton viewTwoButton;
        private displayModeButton viewThreeButton;
        private displayModeButton addAlbButton;
        private displayModeButton delAlbButton;
        private System.Windows.Forms.Button reduceButton;
        private System.Windows.Forms.Button enlargeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView albumsList;
    }
}

