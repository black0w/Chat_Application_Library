using System;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class TextMessageRequestMessage : Message
    {
        public string username { get; set; }

        public string senderDisplayName { get; set; }

        public string senderUserCode { get; set; }

        public string recipientDisplayName { get; set; }

        public string recipientUserCode { get; set; }

        public string content { get; set; }

        public DateTime timeStamp { get; set; }

        public TextMessageRequestMessage()
        {
            Type = MessageType.Request;
            Action = "TextMessage";
        }
    }

}