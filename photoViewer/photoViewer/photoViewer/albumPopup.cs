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
using System.IO;


namespace photoViewer
{
    public partial class albumPopup : Form
    {

        #region DropShadow & Moveable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

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

        // Artributes
        public bool AlbumValid = false;
        public String nameField;
        public String path { get; set; }
        private bool valid = false;
        private int countImg;

        public albumPopup()
        {
            InitializeComponent();
            this.albumName.SelectAll();
            this.albumName.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.nbImg.Text = "x 0";
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public String getTypedName()
        {
            return this.nameField;
        }


        private void validate_Click(object sender, EventArgs e)
        {
            // If the selected folder has pictures and the typed album name are OK
            if ((this.albumName.Text.CompareTo("") != 0) && valid)
            {
                AlbumValid = true;
                this.nameField = this.albumName.Text;
                this.path = this.fileSelector.SelectedPath;
                this.Close();
            }

        }

        private void selectFolder_Click(object sender, EventArgs e)
        {
            string extension = "";
            this.fileSelector.ShowDialog();
            
            // This loop helps us to count how many picture are in the selected folder
            if ( (this.fileSelector.SelectedPath.ToString().Length >5) )
            {
                foreach (string f in Directory.GetFiles(this.fileSelector.SelectedPath))
                {
                    if (!valid)
                    {
                        extension = Path.GetExtension(f);
                        switch (extension)
                        {
                            case ".jpg":
                            case ".png":
                            case ".jpeg":
                            case ".JPEG":
                            case ".JPG":
                            case ".bmp":
                                countImg++;
                                break;
                        }
                    }

                }

                // If the folder contains at least one picture the album can be created (needed by mainWindow)
                if (countImg > 0)
                    valid = true;

                // Update the view
                this.nbImg.Text = "x " + this.countImg.ToString();
            }
        }


    }
}
