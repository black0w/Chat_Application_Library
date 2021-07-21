using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class PingRequestMessage : Message
    {
        public PingRequestMessage()
        {
            Type = MessageType.Request;
            Action = "Ping";
        }
    }
}