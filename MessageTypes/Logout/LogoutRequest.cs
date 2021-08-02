using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
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
