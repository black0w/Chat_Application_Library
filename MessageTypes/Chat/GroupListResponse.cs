using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
    public class GroupListResponse : Message
    {
        public List<GroupInfo> Groups { get; set; }
        public GroupListResponse()
        {
            Type = Type.Response;
            Action = "GroupList";
        }
    }
}
