﻿using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class LogoutRequestMessage : Message
    {
        public string username { get; set; }

        public LogoutRequestMessage()
        {
            Type = Type.Request;
            Action = "Logout";
        }
    }
}