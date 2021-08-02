using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class FriendStatusResponse : Message
    {
        public Result Result { get; set; }

        public string DisplayName { get; set; }

        public string UserCode { get; set; }

        public bool Status { get; set; }
        public FriendStatusResponse()
        {
            Type = Type.Response;
            Action = "Status";
        }
    }
}
