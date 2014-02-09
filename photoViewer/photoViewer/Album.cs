using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoViewer
{
    class AlbumList : List<Album>
    {
    }

    class Album
    {
        // internal attributes
        private string name {get;set;}
        private string subTitle { get; set; }
        private FileInfo detailledInfo { get; set; }
        private string[] keywords{ get; set;} 
        private Image coverPicture {get;set;}
        private PictureList Pictures { get; set; }

        public Album(PictureList pictures)
        {
            this.Pictures = pictures;
            this.name = "quiche"; // FIXME - remove this
        }
    }



}
