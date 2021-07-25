using System;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    public class TextMessageRequest : Message
    {
        public string SenderUsername { get; set; }

        public string SenderDisplayName { get; set; }

        public string SenderUserCode { get; set; }

        public string RecipientDisplayName { get; set; }

        public string RecipientUserCode { get; set; }

        public string Content { get; set; }

        public DateTime TimeStamp { get; set; }

        public TextMessageRequest()
        {
            Type = Type.Request;
            Action = "TextMessage";
        }
    }
}
