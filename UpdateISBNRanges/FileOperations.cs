using System;
using System.IO;
using System.Net;
using System.Xml;

namespace UpdateISBNRanges
{
    class FileOperations
    {

        // delete file in path if exists
        public void deleteFile(string path)
        {
            if (File.Exists(@path))
            {
                File.Delete(@path);
            }

        }


        // get file from API
        public void getFileFromAPI(string path)
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            WebClient client = new WebClient();

            string url = "https://www.isbn-international.org/export_rangemessage.xml";

            client.DownloadFile(url, @path);

        }


        public void Remove_DTD_From_XML(string path)
        {
            try
            {
                XmlDocument XDoc = new XmlDocument();
                XDoc.Load(path);
                XmlDocumentType XDType = XDoc.DocumentType;
                XDoc.RemoveChild(XDType);
                XDoc.Save(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }

}
