using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
   public class GroupChatResponse : Message
    {
        List<int> GroupIds { get; set; }
        public GroupChatResponse()
        {
            Type = Type.Response;
            Action = "GroupChat";
        }
    }
}
