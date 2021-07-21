using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendInviteResponseMessage : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        public FriendInviteResponseMessage()
        {
            Type = MessageType.Response;
            Action = "FriendInvite";
        }

    }

}