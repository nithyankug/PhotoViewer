using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoViewer
{
    class Album
    {
        // internal attributes
        private string name {get;set;}
        private string subTitle { get; set; }
        private FileInfo detailledInfo { get; set; }
        private string[] keywords{ get; set;} 
        private Image coverPicture {get;set;}


        // constructor
        public Album()
        {
            name = null;
            subTitle = null;
            detailledInfo = null;
            keywords = new string[3] { null, null, null };
            coverPicture = null;
        }

    }
}
