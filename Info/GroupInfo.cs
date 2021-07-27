using Application_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library.Info
{
    class GroupInfo
    {
        public List<UserInfo> Members { get; set; }

        public List<MessageInfo> Messages { get; set; }
    }
}
