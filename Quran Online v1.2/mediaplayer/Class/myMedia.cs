using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaplayer.Class
{
    class myMedia
    {

        public string MediaName
        {
            get { return m_MediaName; }
            set { m_MediaName = value; }
        }

        public string MediaSize
        {
            get { return m_MediaSize; }
            set { m_MediaSize = value; }
        }

        private string m_MediaName;

        private string m_MediaSize;
        public myMedia(string strMediaName)
        {
            this.MediaName = strMediaName;

            //*** Image Binary ***'
            IsolatedStorageFile isoStore = IsolatedStorageFile.GetUserStoreForApplication();
            string isoFilename = strMediaName;
            Stream stream = isoStore.OpenFile(isoFilename, System.IO.FileMode.Open);

            //*** Image Size ***'
            this.MediaSize = stream.Length + " Bytes";

            stream.Close();

        }


    }
}
