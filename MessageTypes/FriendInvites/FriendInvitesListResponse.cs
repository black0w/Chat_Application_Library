using Application_Library;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class FriendInvitesListResponse : Message
    {
        public List<UserInfo> FriendRequestsList { get; set; }

        public FriendInvitesListResponse()
        {
            Type = Type.Response;
            Action = "FriendInvitesList";
        }
    }
}