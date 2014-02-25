using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Runtime.InteropServices;

namespace photoViewer
{
    public partial class mainWindow : Form
    {
        // makes the borderless form moveable, we send Message to Windows to move the form given position of the mouse.
        // credit to: Rahul Rajat Singh 
        // source: http://www.codeproject.com/Articles/349883/Making-a-Borderless-Form-Movable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //__________

        private AlbumList albums;


        public mainWindow()
        {
            InitializeComponent();
         
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; // removes the titleBar
        }
       
        private void _RefreshAlbumView()
        {
            albumsTable.Controls.Clear();
      
            foreach (Album a in albums)
            {
                //pictureThumbnail view = new pictureThumbnail();
                Picture thumb = a.GetThumbnail();
                
                
                /*view.SetAlbumName("My first album");
                view.SetPicture(thumb.pictureFile);
                */

                albumThumbnail albumView = new albumThumbnail();
                albumView.setName("My first album");
                albumView.setThumbnail(thumb.pictureFile);

                albumsTable.Controls.Add(albumView);

                if (a.IsActive) // FIXME
                {
                    int i = 0;
                    foreach (Picture p in a.GetPictureList())
                    {
                        pictureThumbnail pv = new pictureThumbnail(); //FIXME
                        pv.SetAlbumName("");
                        Console.WriteLine("Iterating... " + p.pictureFile);
                        pv.SetPicture(p.pictureFile);
                        tableImages.Controls.Add(pv);
                        tableImages.RowCount++;
                    }
                }
            }
        }

        private void mainWindow_Load(object sender, EventArgs e)
        {
            /* Unarchive data (AlbumList) */

            PictureList l, ll;
            l = Picture.ExtractListFromPath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            ll = Picture.ExtractListFromPath(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
            l.ExtendWithList(ll);
            l.LoadAll();

            albums = new AlbumList();
            albums.Add(new Album(l));
            

            _RefreshAlbumView();
        }


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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enlargeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else 
                this.WindowState = FormWindowState.Maximized;

        }


        private void reduceButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void albumList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_MouseDown(object sender, MouseEventArgs e)
        {

        }

        // Callback functions called when form is being moved.
        private void mainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
        }

        private void addAlbButton_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
