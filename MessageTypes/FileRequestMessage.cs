using System;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FileRequestMessage : Message
    {
        public string fileName { get; set; }

        public string senderUsername { get; set; }

        public string recipientDisplayName { get; set;}

        public string recipientUserCode { get; set; }

        public byte[] fileContent { get; set; }

        public InfoType messageType { get; set; }

        public DateTime timeStamp { get; set; }

        public FileRequestMessage()
        {
            Type = Type.Request;
            Action = "File";
        }
    }
}