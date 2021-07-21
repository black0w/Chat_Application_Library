using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class FriendInviteResultResponse : Message
    {
        [XmlElement("Result")]
        public Result Result { get; set; }

        [XmlElement("displayName")]
        public string displayName { get; set; }

        [XmlElement("userCode")]
        public string userCode { get; set; }

        public FriendInviteResultResponse()
        {
            Type = Type.Response;
            Action = "FriendInvite";
        }
    }
}
