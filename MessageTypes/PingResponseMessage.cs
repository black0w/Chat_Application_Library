using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class PingResponseMessage : Message
    {
        [XmlElement("Result")]
        public Result Result { get; set; }

       

        public PingResponseMessage()
        {
            Type = MessageType.Response;
            Action = "Ping";
        }
    }
}