using Application_Library;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class ChatsChronologyResponse : Message
    {
        public List<MessageInfo> messages { get; set; }
        public int GroupId { get; set; }
        public ChatsChronologyResponse()
        {
            Type = Type.Response;
            Action = "ChatChronology";
        }
    }
}
