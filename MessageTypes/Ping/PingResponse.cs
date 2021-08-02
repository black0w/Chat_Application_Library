using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class PingResponse : Message
    {
        [XmlElement("Result")]
        public Result Result { get; set; }

        public PingResponse()
        {
            Type = Type.Response;
            Action = "Ping";
        }
    }
}
