using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
   public class FriendInviteRequest : Message
    {
        public string SenderUsername { get; set; }

        public string RecipientDisplayName { get; set; }

        public string RecipientUserCode { get; set; }

        public FriendInviteRequest()
        {
            Type = Type.Request;
            Action = "FriendInvite";
        }
    }
}
