using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class FriendInviteResultResponse : Message
    {

        public Result Result { get; set; }

        public string DisplayName { get; set; }

        public string UserCode { get; set; }

        public FriendInviteResultResponse()
        {
            Type = Type.Response;
            Action = "FriendInviteResult";
        }
    }
}
