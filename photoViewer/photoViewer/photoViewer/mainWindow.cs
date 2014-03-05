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
using System.Drawing.Text;
using System.IO;

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
        private albumThumbnail albumView;
       

        public mainWindow()
        {
            InitializeComponent();
        }



        private void _RefreshPictureView()
        {
            sizeIndicatorUpdate();
            tableImages.Controls.Clear();
           
            foreach (Album a in albums)
            {
                if (a.IsActive) // FIXME
                {
                    int row = 0;
                    foreach (Picture p in a.GetPictureList())
                    {

                        this.tableImages.ColumnCount = this.sizeDisplay.Value;
                        
                        int thumbnailHeight = ((this.tableImages.Size.Width) / (this.sizeDisplay.Value));
                        int thumbnailWidth = (thumbnailHeight * 80 / 100);
                        
                        pictureThumbnail pictureThumb = new pictureThumbnail(); //FIXME
                        
                        pictureThumb.Size = new System.Drawing.Size(thumbnailHeight, thumbnailWidth);

                        pictureThumb.SetThumbName(p.get());
                        pictureThumb.SetPicture(p.pictureFile);
                        

                        tableImages.Controls.Add(pictureThumb, row, 0);
                        row++;
                       
                    }
                }
            }
        }

        protected void albumsTable_Click()
        {

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
            Album newAlb = new Album(l, "Default Album");
            newAlb.IsActive = true;
            albums.Add(newAlb);

            
           
            _RefreshPictureView();
            _RefreshAlbumView();
        }

        

        #region DropShadow & Moveable
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

        // Callback functions called when form is being moved.
        private void mainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #endregion

        #region Window buttons

        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enlargeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.enlargeButton.BackgroundImage = Properties.Resources.appbar_window_maximize;
                _RefreshPictureView();
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.enlargeButton.BackgroundImage = Properties.Resources.appbar_window_minimize;
                _RefreshPictureView();
            }

        }


        private void reduceButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void albumList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void addAlbButton_Load(object sender, EventArgs e)
        {

        }


        private void sizeDisplay_Scroll(object sender, EventArgs e)
        {

        }

        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            // PopUp that will require the user to define the album
            albumPopup addAlbum = new albumPopup();
            addAlbum.ShowDialog();
            
            // Given the path defined load pictures
            if (addAlbum.AlbumValid)
            {
                PictureList newAlbumList = new PictureList();
                newAlbumList = Picture.ExtractListFromPath(addAlbum.path, false);
                newAlbumList.LoadAll();

                // Add to the main AlbumList
                albums.Add(new Album(newAlbumList, addAlbum.nameField));

            }

            // Refresh
            _RefreshPictureView();
            _RefreshAlbumView();

            
        }

        private void _RefreshAlbumView()
        {
            albumsTable.Controls.Clear();

            foreach (Album a in albums)
            {
                Picture thumb = a.GetThumbnail();

                albumView = new albumThumbnail();
                
                albumView.setName(a.name);
                albumView.setThumbnail(thumb.pictureFile);
                albumView.setNbPhoto(a.GetPictureList().Count);
                
                albumsTable.Controls.Add(albumView);
            }
        }

       

        private void refresh_Click(object sender, EventArgs e)
        {
            _RefreshPictureView();
            _RefreshAlbumView();
        }


        private void sizeIndicatorUpdate()
        {
            this.sizeIndicator.Text = "x " + this.sizeDisplay.Value.ToString();
        }


        private void sizeDisplay_ValueChanged(object sender, EventArgs e)
        {
            _RefreshPictureView();
        }

        #region SLIDESHOW
        private void startSlideshow_Click(object sender, EventArgs e)
        {
            
            List<Image> toSend = new List<Image>();
            String nameOfAlbum="";
            FileInfo nameOfPicture = null;
            Image imgToSend;

            // We send an List<Image> it is far enough for the slideshow purpose
            foreach (Album a in albums)
            {
                if (a.IsActive)
                {
                    foreach (Picture b in a.GetPictureList())
                    {
                        // Get the Image from our own made class Picture
                        imgToSend = b.pictureFile;

                        // We bind the name for the later display
                        nameOfPicture=b.picInfo;
                        imgToSend.Tag = nameOfPicture.Name;

                        // Adding to the list
                        toSend.Add(imgToSend);
                        
                    }
                    nameOfAlbum=a.name;
                }
            }

            // Launching the slideshow
            slideShow diapo = new slideShow(toSend,nameOfAlbum);
            diapo.ShowDialog();

        }
        #endregion 




    }
}