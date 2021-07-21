using Application_Library;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class FriendListResponse : Message
    {
        [XmlElement("Result")]
        public Result Result { get; set; }

        [XmlElement("Info")]
        public List<UserInfo> FriendList { get; set; }

        public FriendListResponse()
        {
            Type = Type.Response;
            Action = "FriendList";
        }
    }
}
