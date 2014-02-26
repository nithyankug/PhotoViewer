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
    public partial class albumThumbnail : UserControl
    {
        private bool isActive = false;
        public bool getState()
        {
            return this.isActive;
        }

        public albumThumbnail()
        {
            InitializeComponent();
        }

        public void setName(String nameToSet){
            this.albumName.Text = nameToSet;
        }

        public void setThumbnail(Image imgtoSet)
        {
            this.thumbnail.Image = imgtoSet;
        }

        private void albumName_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.isActive = true;
            Console.Beep();
            
        }



    }

    
}
