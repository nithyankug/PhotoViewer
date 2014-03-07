using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace photoViewer
{
    [Serializable]
    public class Picture
    {
        // internal attributes
        [XmlIgnore] public FileInfo picInfo { get; set; }
        [XmlIgnore] public Image pictureFile { get; set; }
        public string category { get; set; }
        public int rating { get; set; }
        public string comment { get; set; }
        private int nbInstance { get; set; }
        public string _filename; // Internal usage (fileinfo is not serializable)
       
        public Picture() {}

        public Picture(string path)
        {
            _filename = path;
            picInfo = new FileInfo(path);  
        }

        public void Load()
        {
            if (picInfo == null) picInfo = new FileInfo(_filename);
            pictureFile = Image.FromFile(picInfo.FullName);
        }

        static public bool IsSupportedFormat(string extension)
        {
            if (extension == null) return false;
            switch (extension)
            {
                /* Add extensions to this list IF they are supported! */
                case ".jpg":
                case ".png":
                case ".jpeg":
                case ".bmp":
                    return true;
            }

            return false;
        }

        static public PictureList ExtractListFromPath(string path, bool recursive = true)
        {
            PictureList list = new PictureList();
            // FIXME is path is a file, import it!
            Console.WriteLine(path);
            foreach (string f in Directory.GetFiles(path))
            {
                if (IsSupportedFormat(Path.GetExtension(f)))
                {
                    Picture p = new Picture(f);
                    list.Add(p);
                }
            }

            if (recursive)
            {
                PictureList l = null;
                foreach (string d in Directory.GetDirectories(path))
                    l = ExtractListFromPath(d, true);
                list.ExtendWithList(l);
            }
              

            return list;
        }

    }

    [Serializable]
    public class PictureList : List<Picture>
    {
        public void ExtendWithList(PictureList extend)
        {
            if (extend == null) return;
            foreach (Picture p in extend)
                this.Add(p);
        }

        public void LoadAll()
        {
            foreach (Picture p in this)
                p.Load();
        }

        public PictureList() { }
        
    }

}
