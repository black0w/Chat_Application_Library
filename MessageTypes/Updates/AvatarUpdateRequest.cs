using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
   public class AvatarUpdateRequest : Message
    {
        public string Username       { get; set; }
        public string Avatar         { get; set; }

        public AvatarUpdateRequest()
        {
            Type = Type.Request;
            Action = "AvatarUpdate";
        }
    }
}
