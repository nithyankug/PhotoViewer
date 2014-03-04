using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace photoViewer
{ 
    class Picture
    {
        // internal attributes
        public FileInfo picInfo { get; set; }
        public Image pictureFile { get; set; }
        private string category { get; set; }
        private int rating { get; set; }
        private string comment { get; set; }
        private int nbInstance { get; set; }
        public String get()
        {
            return picInfo.Name;
        }
        public Picture(string path)
        {
            picInfo = new FileInfo(path);
           
        }

        public void Load()
        {
            if (picInfo == null) return;
            pictureFile = Image.FromFile(picInfo.FullName);
            Console.WriteLine("Loading: " + picInfo.FullName);
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

    class PictureList : List<Picture>
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

        
    }

}
