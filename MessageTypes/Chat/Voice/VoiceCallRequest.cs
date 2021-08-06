using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
    public class VoiceCallRequest : Message
    {
        public int GroupID { get; set; }
        public string User { get; set; }
        public VoiceCallRequest()
        {
            Type = Type.Request;
            Action = "VoiceCallRequest";
        }
    }
}