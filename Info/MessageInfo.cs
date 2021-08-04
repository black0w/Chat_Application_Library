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
        public string SenderAvatar { get; set; }
        public InfoType MessageType { get; set; }
        public byte[] FileContent { get; set; }
        public string FileName { get; set; }
        public string Content { get; set; }
    }
}
