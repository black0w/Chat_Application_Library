using Application_Library;
using System;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class DeleteMessageRequest : Message
    {
        public string SenderDisplayName { get; set; }
        public string SenderUserCode { get; set; }
        public int GroupID { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }

        public InfoType MessageType { get; set; }

        public DeleteMessageRequest()
        {
            Type = Type.Request;
            Action = "MessageDelete";
        }
    }
}
