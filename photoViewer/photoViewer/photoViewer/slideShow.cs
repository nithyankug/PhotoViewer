using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace photoViewer
{
    public partial class slideShow : Form
    {
        private List<Image> toDisplay=null;
        private bool playState;
        private int counter;
       

        public slideShow(List<Image> receivedAlbum,String name)
        {
            InitializeComponent();
            
            // Getting the images
            toDisplay = receivedAlbum;
            this.albumNameLabel.Text = name;

            // Configuration of the timer
            myTimer.Tick += new EventHandler(slideshowLaunch_Tick);
            myTimer.Interval = ( int.Parse(this.timerInter.Value.ToString()) * 1000);
            
            // Setting the launching parameters
            myTimer.Start();
            this.playButton.BackgroundImage = Properties.Resources.appbar_control_pause;

            
        }
         

        public void slideshowLaunch_Tick(Object sender,EventArgs e)
        {

            // At every tick
            if (toDisplay[counter]!= null)
            {
                // Displaying the picture
                this.imageSlide.BackgroundImage = toDisplay[counter];

                // Updating the labels
                this.pictureNameLabel.Text = toDisplay[counter].Tag.ToString(); 
                this.pictureCounter.Text = (counter+1).ToString();
            }

            // Boundary to loop in available 
            if (toDisplay.Count > counter + 1)
                counter++;
            else
                counter = 0;
           
            
        }

        // Window closing
        private void closeSlideShow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Parameters at launch
        private void slideShow_Load(object sender, EventArgs e)
        {
            // Initialization of the labels
            this.pictureNameLabel.Text = toDisplay[counter].Tag.ToString();
            this.pictureCounter.Text = (counter + 1).ToString();
            this.imageSlide.BackgroundImage = toDisplay[counter];
            counter = 0;
            playState = true ;
        }

        // Management of the PLAY / PAUSE function of the slideshow
        private void playButton_Click(object sender, EventArgs e)
        {
            
            if (!playState)
            {
                this.playButton.BackgroundImage = Properties.Resources.appbar_control_pause;
                playState = true;
                myTimer.Start();
            }

            else
            {
                this.playButton.BackgroundImage = Properties.Resources.appbar_control_play;
                playState = false;
                myTimer.Stop();
            }

            
        }

        // Readjust the timer's interval when is it being changed
        private void timerInter_ValueChanged(object sender, EventArgs e)
        {
            myTimer.Interval = (int.Parse(this.timerInter.Value.ToString()) * 1000);
        }

        private void previous_Click(object sender, EventArgs e)
        {
            // Stop the display
            myTimer.Stop();
            this.playButton.BackgroundImage = Properties.Resources.appbar_control_play;
            
            // Boundary to loop in available 
            if (counter>0)
                counter--;
            else
                counter = (toDisplay.Count)-1;

            // Displaying the picture
            this.imageSlide.BackgroundImage = toDisplay[counter];

            // Updating the labels
            this.pictureNameLabel.Text = toDisplay[counter].Tag.ToString();
            this.pictureCounter.Text = (counter + 1).ToString();
        }

        private void next_Click(object sender, EventArgs e)
        {
            // Stop the display
            myTimer.Stop();
            this.playButton.BackgroundImage = Properties.Resources.appbar_control_play;

            // Boundary to loop in available 
            if (toDisplay.Count > counter + 1)
                counter++;
            else
                counter = 0;

            // Displaying the picture
            this.imageSlide.BackgroundImage = toDisplay[counter];

            // Updating the labels
            this.pictureNameLabel.Text = toDisplay[counter].Tag.ToString();
            this.pictureCounter.Text = (counter + 1).ToString();
        }
        
    }
}
