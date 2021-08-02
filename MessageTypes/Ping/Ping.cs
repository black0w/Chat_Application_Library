﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class Ping : Message
    {
        public Ping()
        {
            Type = Type.Request;
            Action = "Ping";
        }
    }
}
