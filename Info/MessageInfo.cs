using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class MessageInfo
    {
        public string SenderUsername { get; set; }

        public string SenderDisplayName { get; set; }

        public string SenderUserCode { set; get; }

        public List<string> RecipientUsername { get; set; }

        public string RecipientDisplayName { get; set; }

        public string RecipientUserCode { get; set; }

        public DateTime TimeStamp { get; set; }

        public InfoType messageType { get; set; }

        public string fileContent { get; set; }

        public string Content { get; set; }
    }
}
