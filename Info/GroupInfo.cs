using Application_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
    class GroupInfo
    {
        public List<UserInfo> Members { get; set; }
        public int GroupID { get; set; }
        //  public List<MessageInfo> Messages { get; set; }
    }
}
