using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    public class MessageInfo
    {
        public string SenderDisplayName { get; set; }
        public string SenderUserCode { set; get; }
        public DateTime TimeStamp { get; set; }
        public string Avatar { get; set; }
        public InfoType messageType { get; set; }
        public string fileContent { get; set; }
        public string Content { get; set; }
    }
}
