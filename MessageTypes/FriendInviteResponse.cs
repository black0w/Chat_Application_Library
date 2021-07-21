using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendInviteResponse : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        [XmlElement("username")]
        public string username { get; set; }

        [XmlElement("displayName")]
        public string displayName { get; set; }

        [XmlElement("userCode")]
        public string userCode { get; set; }
        public FriendInviteResponse()
        {
            Type = MessageType.Response;
            Action = "FriendInvite";
        }

    }

}