using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendRequestsListResponseMessage : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        [XmlElement("Info")]
        public List<UserInfo> FriendRequestsList { get; set; }

        public FriendRequestsListResponseMessage()
        {
            Type = MessageType.Response;
            Action = "FriendRequestsList";
        }

    }

}