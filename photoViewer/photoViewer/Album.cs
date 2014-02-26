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
        public string name {get;set;}
        private string subTitle { get; set; }
        private FileInfo detailledInfo { get; set; }
        private string[] keywords{ get; set;} 
        private Image coverPicture {get;set;}
        private PictureList Pictures { get; set; }
        private Picture thumbnail {get; set;}
        public bool IsActive { get; set; }

        public void setIsActive(bool stateToSet)
        {
            this.IsActive = stateToSet;
        }

        public Album(PictureList pictures,String name)
        {
            this.Pictures = pictures;
            this.IsActive = true;
            this.name = name;
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
