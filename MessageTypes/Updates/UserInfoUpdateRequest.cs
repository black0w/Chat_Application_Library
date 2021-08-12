using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
    public class UserInfoUpdateRequest : Message
    {
        public string Username               { get; set; }
        public string Avatar                 { get; set; }
        public string OldPassword            { get; set; }
        public string NewPassword            { get; set; }
        public string DisplayName            { get; set; }
        public string Email                  { get; set; }

        public UserInfoUpdateRequest()
        {
            Type = Type.Request;
            Action = "UserInfoUpdate";
        }
    }

    public class UserInfoUpdateResponse : Message
    {
        public Result Status                 { get; set; }
        public Error Error                   { get; set; }
        public UserInfoUpdateResponse()
        {
            Type = Type.Request;
            Action = "UserInfoUpdate";
        }
    }

    public class FriendAvatarUpdateResponse : Message
    {
        public string Avatar                { get; set; }
        public string DisplayName           { get; set; }
        public string UserCode              { get; set; }
        public FriendAvatarUpdateResponse()
        {
            Type = Type.Response;
            Action = "FriendAvatarUpdate";
        }
    }

    public class FriendDisplayNameUpdateResponse : Message
    {
        public string OldDisplayName { get; set; }
        public string DisplayName { get; set; }
        public string UserCode { get; set; }
        public FriendDisplayNameUpdateResponse()
        {
            Type = Type.Response;
            Action = "FriendDisplayNameUpdate";
        }
    }
}
