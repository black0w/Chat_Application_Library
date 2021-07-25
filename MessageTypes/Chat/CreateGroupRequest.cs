using Application_Library;
using System.Collections.Generic;

namespace Chat_Application_Library
{
    public class CreateGroupRequest : Message
    {
        public string SenderUsername { get; set; }
        public List<UserInfo> Users { get; set; } //display name and user code
        public CreateGroupRequest()
        {
            Type = Type.Request;
            Action = "CreateGroup";
        }
    }
}
