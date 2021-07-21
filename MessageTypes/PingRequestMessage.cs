using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class PingRequestMessage : Message
    {
        public PingRequestMessage()
        {
            Type = Type.Request;
            Action = "Ping";
        }
    }
}