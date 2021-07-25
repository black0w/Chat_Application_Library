using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
    public class Ping : Message
    {
        public Ping()
        {
            Type = Type.Request;
            Action = "Ping";
        }
    }
}
