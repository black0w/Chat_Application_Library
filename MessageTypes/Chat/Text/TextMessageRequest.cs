using Application_Library;
using System;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class TextMessageRequest : Message
    {
        public string SenderDisplayName     { get; set; }
        public string SenderUserCode        { get; set; } 
        public string Avatar                { get; set; }
        public int GroupID                  { get; set; }
        public string Content               { get; set; }
        public DateTime TimeStamp           { get; set; }
        public InfoType MessageType         { get; set; }

        public TextMessageRequest()
        {
            Type = Type.Request;
            Action = "TextMessage";
        }
    }
}
