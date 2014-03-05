﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoViewer
{
    public partial class pictureThumbnail : UserControl
    {
        public pictureThumbnail()
        {
            InitializeComponent();
        }

        public void SetThumbName(string str)
        {
            this.theAlbum.Text = str;
        }

        public void SetPicture(Image img)
        {
            this.thumbnail.BackgroundImage = img;
           
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void thumbnail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            detailledPhoto view = new detailledPhoto();
            
            view.ShowDialog();
        }
    }
}
