using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoViewer
{
    class Picture
    {
        // internal attributes
        private FileInfo picInfo { get; set; }
        private Image pictureFile { get; set; }
        private string category { get; set; }
        private int rating { get; set; }
        private string comment { get; set; }
        private int nbInstance { get; set; }

        // constructor
        public Picture()
        {
            // basic initialization
            picInfo = null;
            pictureFile = null;
            category = "" ;
            rating = 0;
            comment = "";
            nbInstance = 0;
        }

        

    }
}
