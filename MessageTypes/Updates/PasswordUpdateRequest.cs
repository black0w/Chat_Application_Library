using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
   public class PasswordUpdateRequest : Message
    {
        public string Username          { get; set; }
        public string OldPassword       { get; set; }
        public string NewPassword       { get; set; }

        public PasswordUpdateRequest()
        {
            Type = Type.Request;
            Action = "AvatarUpdate";
        }
    }
}
