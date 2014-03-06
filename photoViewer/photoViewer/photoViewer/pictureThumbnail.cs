using System;
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
        public Picture photo = null;
       

        public pictureThumbnail()
        {
            InitializeComponent();
        }

        public void SetThumbName()
        {
            if (photo != null)
            this.theAlbum.Text = this.photo.picInfo.Name;
        }

        public void SetPicture()
        {
            if(photo!=null)
            this.thumbnail.BackgroundImage = this.photo.pictureFile;
           
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void thumbnail_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            detailPhoto view = new detailPhoto();
            view.shownPicture = this.photo;
            view.configuration();
            view.ShowDialog();

            if (view.shownPicture.picInfo.Name != view.fieldName.Text)
            {

            }
        }
    }
}
