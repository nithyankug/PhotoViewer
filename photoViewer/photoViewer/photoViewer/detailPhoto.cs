﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace photoViewer
{
    public partial class detailPhoto : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Picture shownPicture=null;

        public detailPhoto()
        {
            InitializeComponent();
        }


        public void configuration()
        {
            this.photoView.BackgroundImage = this.shownPicture.pictureFile;
            this.fieldName.Text = this.shownPicture.picInfo.Name;
            this.fieldDate.Text = this.shownPicture.picInfo.CreationTime.ToString();
            this.fieldRating.Text = this.shownPicture.rating.ToString();
            this.fieldComment.Text = this.shownPicture.comment;
        }
        #region DropShadow 
        // Adds the dropshadow
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = CS_DROPSHADOW;
                return cp;
            }
        }
        
        #endregion

        private void closeView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
