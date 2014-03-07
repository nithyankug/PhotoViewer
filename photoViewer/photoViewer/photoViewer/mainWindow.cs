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
using System.Reflection;
using System.Diagnostics;
using System.Xml.Serialization;

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
        private Picture big;
        //private int Click;
        private XmlSerializer _xs;

        public mainWindow()
        {
            InitializeComponent();
        }



        private void _RefreshPictureView()
        {
            sizeIndicatorUpdate();
            tableImages.Controls.Clear();

            if (albums == null) return; // Safety check
            foreach (Album a in albums)
            {
                if (a.IsActive) // FIXME
                {
                    int row = 0;
                    foreach (Picture p in a.GetPictureList())
                    {

                        this.tableImages.ColumnCount = this.sizeDisplay.Value;
                        big = p;
                        int thumbnailHeight = ((this.tableImages.Size.Width) / (this.sizeDisplay.Value));
                        int thumbnailWidth = (thumbnailHeight * 80 / 100);

                        pictureThumbnail pictureThumb = new pictureThumbnail(); //FIXME
                        pictureThumb.photoView.MouseClick += new MouseEventHandler((sender, e) => detailedView(sender, e, p));
                        pictureThumb.deleteButton.Click += new EventHandler((sender, e) => deletePicture(sender, e, p));
                        pictureThumb.Size = new System.Drawing.Size(thumbnailHeight, thumbnailWidth);
                        pictureThumb.photo = p;
                        pictureThumb.SetThumbName();
                        pictureThumb.SetPicture();


                        tableImages.Controls.Add(pictureThumb, row, 0);
                        row++;

                    }
                }
            }
        }

        public void detailedView(object sender, EventArgs e, Picture p)
        {
            /*
            detailPhoto view = new detailPhoto();
            view.shownPicture = p;
            view.configuration();
            view.ShowDialog();
            deletePicture(null,null,p);
            Picture toSet = p;
            

            foreach (Album alb in albums)
            {
                
                    if (view.fieldName.Text.CompareTo(p.picInfo.Name) != 0
                        || view.fieldCatergory.Text.CompareTo(p.category)!=0
                        || view.fieldComment.Text.CompareTo(p.comment)!=0
                        || view.fieldRating.Text.CompareTo(p.rating)!=0)

                    {
                        foreach (Picture pic in alb.GetPictureList())
                        {
                            
                        }
                    }
                
            }

       */

        }

        public void deletePicture(object sender, EventArgs e, Picture p)
        {
            foreach (Album alb in albums)
            {
                if (alb.IsActive)
                {
                    alb.GetPictureList().Remove(p);
                }

            }

            // Refresh the display
            _RefreshPictureView();
            _RefreshAlbumView();
        }
        protected void albumsTable_Click()
        {

        }

        private void mainWindow_Load(object sender, EventArgs e)
        {

            try
            {
                //Picture p = new Picture("C:\\a.jpg");
                //_xs = new XmlSerializer(typeof(Picture));
                _xs = new System.Xml.Serialization.XmlSerializer(typeof(AlbumList));
                this.load();
                //_xs.Serialize(Console.Out, p);
            }
            catch (Exception excp)
            {
                Console.WriteLine("********");
                Console.WriteLine("********");
                Console.WriteLine("******** " + excp.Message);
                Console.WriteLine("******** " + excp.InnerException.Message);
                Console.WriteLine("********");
                Console.WriteLine("********");
            }
            /*
                        PictureList l, ll;
                        l = Picture.ExtractListFromPath(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
                        ll = Picture.ExtractListFromPath(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
                        l.ExtendWithList(ll);
                        l.LoadAll();

                        albums = new AlbumList();
                        Album newAlb = new Album(l, "Default Album");
                        newAlb.IsActive = true;
                        albums.Add(newAlb);

        
           
                    */


            _RefreshPictureView();
            _RefreshAlbumView();
        }

        private void save()
        {
           
                if (albums == null) return;
                using (StreamWriter wr = new StreamWriter("Albums.xml"))
                {

                    try
                    {
                        _xs.Serialize(wr, albums);
                    }
                    catch (Exception excp)
                    {
                        Console.WriteLine("******** ERR");
                        Console.WriteLine("********");
                        Console.WriteLine("******** " + excp.Message);
                        Console.WriteLine("******** " + excp.InnerException.Message);
                        Console.WriteLine("********");
                        Console.WriteLine("********");
                    }
                    finally
                    {
                        wr.Close();
                    }
                }
          
        }


        private void load()
        {
            string path = "Albums.xml";
            FileStream fs;


            if (!File.Exists(path))
            {
                fs = File.Create(path);
                fs.Close();
            }

            using (StreamReader rd = new StreamReader("Albums.xml"))
            {
                try
                {
                    albums = _xs.Deserialize(rd) as AlbumList;
                    if (albums.Count >= 1)
                    {
                        albums.SetActive(0);
                    }
                }
                catch (Exception excp)
                {
                    Console.WriteLine("********");
                    Console.WriteLine("********");
                    Console.WriteLine("******** " + excp.Message);
                    Console.WriteLine("******** " + excp.InnerException.Message);
                    Console.WriteLine("********");
                    Console.WriteLine("********");
                }
                finally
                {
                    rd.Close();
                }


                if (albums == null)
                {
                    load_default();
                    save();
                }
            }
        }

        private void load_default()
        {
            PictureList pl;

            pl = Picture.ExtractListFromPath(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
            Album a = new Album(pl, "Shared Pictures");
            albums = new AlbumList();
            albums.Add(a);
            albums.SetActive(a);
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
                albumView.Click += new EventHandler((sender, e) => activateAlbum(sender, e, a.name));
                albumView.deleteAlbum.Click += new EventHandler((sender, e) => deleteAlbum(sender, e, a.name));
                albumsTable.Controls.Add(albumView);

            }
        }

        private void deleteAlbum(object sender, EventArgs e, string p)
        {
            Album toBedeleted = new Album();

            foreach (Album alb in albums)
            {
                if (alb.name.CompareTo(p) == 0)
                {
                    toBedeleted = alb;
                }
            }
            // Delete the wanted album
            albums.Remove(toBedeleted);

            // Refresh all views
            _RefreshAlbumView();
            _RefreshPictureView();

        }

        public void activateAlbum(object sender, EventArgs e, String a)
        {
            // Set the clicked album to true
            foreach (Album alb in albums)
            {
                alb.IsActive = false;

                if (alb.name.CompareTo(a) == 0)
                {
                    alb.IsActive = true;
                }
            }

            // Refresh the view
            _RefreshAlbumView();
            _RefreshPictureView();
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
            if (albums.Count > 0)
            {
                List<Image> toSend = new List<Image>();
                String nameOfAlbum = "";
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
                            nameOfPicture = b.picInfo;
                            imgToSend.Tag = nameOfPicture.Name;

                            // Adding to the list
                            toSend.Add(imgToSend);

                        }
                        nameOfAlbum = a.name;
                    }
                }

                // Launching the slideshow
                slideShow diapo = new slideShow(toSend, nameOfAlbum);
                diapo.ShowDialog();
            }


        }
        #endregion

        #region WEBPAGE
        private void webView_Click(object sender, EventArgs e)
        {
            if (albums.Count > 0)
            {
                try
                {
                    StreamWriter webPageGen = new StreamWriter(Assembly.GetExecutingAssembly().Location + "album.html");
                    String picturePath;
                    String albumName;


                    // Looping to find the active Album
                    foreach (Album a in albums)
                    {
                        if (a.IsActive)
                        {

                            int j = 0;
                            albumName = a.name;

                            // Header of the HTML file.
                            webPageGen.WriteLine("<html>\n<head>\n<title>" + albumName + "</title>\n</head>\n<body Bgcolor=\"#333333\"><p align=\"center\">\n<b><u><div align=\"center\"><center>\n <br>	<table border=\"0\" cellpadding=\"3\" cellspacing=\"10\" width=\"600\">");
                            MessageBox.Show(albums.Count.ToString());
                            // Opens a row
                            webPageGen.WriteLine("<tr>");

                            foreach (Picture p in a.GetPictureList())
                            {

                                // Get the picture path
                                picturePath = p.picInfo.FullName;

                                // Center and display a picture
                                webPageGen.WriteLine("<td width=\"120\" align=\"center\">\n<img border=\"0\" src=\" " + picturePath + "\" align=\"center\" width=120 height=120></a></td>");
                                j++;

                                // 4 pictures per row
                                if (j % 4 == 0)
                                {
                                    webPageGen.WriteLine("</tr>");
                                    webPageGen.WriteLine("<tr>");
                                }

                            }
                            // Closing header
                            webPageGen.WriteLine("</center>\n</div>\n\n</body>\n</html>");
                            webPageGen.Close();
                        }


                    }

                    // Launching a process to open the html File generated
                    Process showWebPage = new Process();
                    showWebPage.StartInfo.FileName = Assembly.GetExecutingAssembly().Location + "album.html";
                    showWebPage.Start();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }
        #endregion



    }
}