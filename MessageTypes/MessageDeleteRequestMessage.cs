using System;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class MessageDeleteRequestMessage : Message
    {
        public string username { get; set; }

        public string friendDisplayName { get; set; }

        public string friendUserCode { get; set; }

        public DateTime timeStamp { get; set; }


        public MessageDeleteRequestMessage()
        {
            Type = Type.Request;
            Action = "MessageDelete";
        }
    }
}