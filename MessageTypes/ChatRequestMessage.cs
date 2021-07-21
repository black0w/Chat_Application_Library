using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class ChatRequestMessage : Message
    {
        public string username { get; set; }

        public string friendDisplayName { get; set; }

        public string friendUserCode { get; set; }

        public ChatRequestMessage()
        {
            Type = MessageType.Request;
            Action = "Chat";
        }
    }
}