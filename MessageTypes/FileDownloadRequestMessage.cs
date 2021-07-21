using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FileDownloadRequestMessage : Message
    {
        public string fileName { get; set; }

        //   public int Hash { get; set; }
        public string senderDisplayName { get; set; }

        public string senderUserCode { get; set; }

        public string recipientDisplayName { get; set; }

        public string recipientUserCode { get; set; }

        public DateTime timeStamp { get; set; }
        public FileDownloadRequestMessage()
        {
            Type = MessageType.Request;
            Action = "FileDownload";
        }
    }
}
