using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
   public class FriendInviteAnswerResponse : Message
    {
        [XmlElement("Result")]
        public Result Result { get; set; }

        [XmlElement("username")]
        public string SenderUsername { get; set; }

        [XmlElement("displayName")]
        public string DisplayName { get; set; }

        [XmlElement("userCode")]
        public string UserCode { get; set; }

        public FriendInviteAnswerResponse()
        {
            Type = Type.Response;
            Action = "FriendInviteAnswer";
        }
    }
}
