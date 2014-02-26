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
    public partial class addAlbumPopUp : Form
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
        private String nameField;

        public addAlbumPopUp()
        {
            InitializeComponent();
            this.albumName.SelectAll();
            this.albumName.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.nameField = this.albumName.Text;
            this.Close();
        }

    }
}
