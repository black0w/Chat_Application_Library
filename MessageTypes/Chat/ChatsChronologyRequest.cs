using System;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class ChatsChronologyRequest : Message
    {
        public int GroupId { get; set; }
        public ChatsChronologyRequest()
        {
            Type = Type.Request;
            Action = "ChatChronology";
        }
    }
}
