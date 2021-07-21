using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class ChatResponseMessage : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        [XmlElement("Info")]
        public List<MessageInfo> messages { get; set; }

        public ChatResponseMessage()
        {
            Type = Type.Response;
            Action = "Chat";
        }

    }

}