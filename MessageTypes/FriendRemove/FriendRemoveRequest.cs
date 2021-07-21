using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class FriendRemoveRequest : Message
    {
        [XmlElement("username")]
        public string Username { get; set; }

        [XmlElement("displayName")]
        public string DisplayName { get; set; }

        [XmlElement("userCode")]
        public string UserCode { get; set; }
        public FriendRemoveRequest()
        {
            Type = Type.Request;
            Action = "FriendRemove";
        }
    }
}
