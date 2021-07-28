using Application_Library;
using System;
using System.Collections.Generic;

namespace Chat_Application_Library
{
    public class GroupInfo
    {
        public List<UserInfo> Members { get; set; }
        public List<MessageInfo> Messages { get; set; }
        public DateTime LastSentMessageTimeStamp { get; set; }
        public MessageInfo LastSentMessage { get; set; }
        public int GroupID { get; set; }
    }
}
