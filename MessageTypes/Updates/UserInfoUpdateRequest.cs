using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
   public class UserInfoUpdateRequest : Message
    {
        public UpdateType UpdateType { get; set; }
        public string Username       { get; set; }
        public string Avatar         { get; set; }
        public string OldPassword    { get; set; }
        public string NewPassword    { get; set; }
        public string DisplayName    { get; set; }

        public UserInfoUpdateRequest()
        {
            Type = Type.Request;
            Action = "AvatarUpdate";
        }
    }
}
