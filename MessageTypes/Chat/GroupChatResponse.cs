using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
   public class GroupChatResponse : Message
    {
        List<GroupInfo> Groups { get; set; }
        public GroupChatResponse()
        {
            Type = Type.Response;
            Action = "GroupList";
        }
    }
}
