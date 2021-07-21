using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendListResponseMessage : Message
    {
        [XmlElement("Result")]
        public Result Result { get; set; }

        [XmlElement("Info")]
        public List<UserInfo> FriendList { get; set; }

        public FriendListResponseMessage()
        {
            Type = Type.Response;
            Action = "FriendList";
        }
    }
}