using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photoViewer
{
    class PictureList : List<Picture>
    {
        public void ExtendWithList(PictureList extend)
        {
            if (extend == null) return;
            foreach (Picture p in extend)
                this.Add(p);
        }
    }

    class Picture
    {
        // internal attributes
        private FileInfo picInfo { get; set; }
        private Image pictureFile { get; set; }
        private string category { get; set; }
        private int rating { get; set; }
        private string comment { get; set; }
        private int nbInstance { get; set; }

        public Picture(string path)
        {
            picInfo = new FileInfo(path);
        }

        static public bool IsSupportedFormat(string extension)
        {
            bool isSupported = false;

            if (extension == null) return false;
            switch (extension)
            {
                /* Add extensions to this list IF they are supported! */
                case ".jpg":
                case ".png":
                case ".jpeg":
                case ".bmp":
                    isSupported = true;
                    break;
            }

            return isSupported;
        }

        static public PictureList ExtractListFromPath(string path, bool recursive = true)
        {
            PictureList list = new PictureList();
            
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
}
