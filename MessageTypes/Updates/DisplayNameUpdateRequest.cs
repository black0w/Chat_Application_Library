using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
   public class DisplayNameUpdateRequest : Message
    {
        public string Username          { get; set; }
        public string NewDisplayName    { get; set; }

        public DisplayNameUpdateRequest()
        {
            Type = Type.Request;
            Action = "AvatarUpdate";
        }
    }
}
