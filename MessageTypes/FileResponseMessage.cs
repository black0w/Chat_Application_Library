using System;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FileResponseMessage : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        public byte[] imageContent { get; set; }

        public string DisplayName { get; set; }

        public string UserCode { get; set; }

        public DateTime TimeStamp { get; set; }

        public string FileName { get; set; }

        public FileResponseMessage()
        {
            Type = MessageType.Response;
            Action = "File";
        }

    }
}