using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace photoViewer
{
    public partial class albumThumbnail : UserControl
    {
        private bool activate = false;
        public delegate void delegateAlbumName(String nom);
        public event delegateAlbumName clickAlbum;
        public String name;

        void print()
        {
            activate = false;
            if(clickAlbum!=null)
            clickAlbum(name);

        }
        public bool getState()
        {
            return this.activate;
        }

        public albumThumbnail()
        {
            InitializeComponent();
           
        }

        public void setName(String nameToSet)
        {
            this.albumName.Text = nameToSet;
        }

        public void setThumbnail(Image imgtoSet)
        {
            this.thumbnail.Image = imgtoSet;
        }

        public void setNbPhoto(int nb)
        {
            this.nbPhoto.Text = nb.ToString();
        }

        private void albumName_TextChanged(object sender, EventArgs e)
        {

        }


        private void albumThumbnail_Click(object sender, EventArgs e)
        {
            
            this.activate = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            
        }



    }


}