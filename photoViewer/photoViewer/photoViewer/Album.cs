using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace photoViewer
{
    [Serializable]
    public class AlbumList : List<Album>
    {
        public void SetActive(Album album)
        {
            foreach (Album a in this)
                a.IsActive = true;// (a == album);
        }

        public void SetActive(int idx)
        {
            foreach (Album a in this)
                this[idx].IsActive = (this[idx] == a);
        }

    }

    [Serializable]
    public class Album
    {
        // internal attributes
        public string name { get; set; }
        public string subTitle { get; set; }

        private FileInfo detailledInfo { get; set; }

        public string[] keywords { get; set; }
        //[XmlIgnore] public Image coverPicture { get; set; }
        public PictureList Pictures;
        public Picture coverPicture { get; set; }
        public Picture thumbnail { get; set; }
        public bool IsActive { get; set; }

        public void setIsActive(bool stateToSet)
        {
            this.IsActive = stateToSet;
        }

        public Album()
        {
        }

        public void Load()
        {
            this.Pictures.LoadAll();
        }

        public Album(PictureList pictures, String name)
        {
            this.Pictures = pictures;
            this.IsActive = false;
            this.name = name;
        }

        public PictureList GetPictureList()
        {
            return this.Pictures;
        }

        public Picture GetThumbnail()
        {
            if (thumbnail == null)
                return Pictures[0];
            return thumbnail;
        }
    }
}