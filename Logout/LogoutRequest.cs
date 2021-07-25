using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
   public class LogoutRequest : Message
    {
        public string Username { get; set; }

        public LogoutRequest()
        {
            Type = Type.Request;
            Action = "Logout";
        }
    }
}
