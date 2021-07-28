using Chat_Application_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application_Library
{
    public class UserInfo
    {
        public string Username { get; set; }

        public string DisplayName { get; set; }

        public string UserCode { get; set; }

        public string Email { get; set; }

        public string Avatar { get; set; }

        public string Password { get; set; }

        public bool IsOnline { get; set; }

        public List<UserInfo> FriendList { get; set; }

        public List<UserInfo> FriendRequestsList { get; set; }

        public List<int> GroupIds { get; set; }
        public List<GroupInfo> Groups {get;set;}
    }
}
