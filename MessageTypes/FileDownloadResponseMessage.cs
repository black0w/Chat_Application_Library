using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FileDownloadResponseMessage : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        public string fileName;

        public byte[] content;

        public FileDownloadResponseMessage()
        {
            Type = Type.Response;
            Action = "FileDownload";
        }

    }
}