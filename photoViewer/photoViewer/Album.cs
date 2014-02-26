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
        private Picture thumbnail {get; set;}
        public bool IsActive { get; set; }

        public Album(PictureList pictures)
        {
            this.Pictures = pictures;
            this.IsActive = true;
        }

        public PictureList GetPictureList()
        {
            return Pictures;
        }

        public Picture GetThumbnail()
        {
            if (thumbnail == null)
                return Pictures[0];
            return thumbnail;
        }
    }
}
