using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendRemoveRequest : Message
    {

        [XmlElement("username")]
        public string username { get; set; }

        [XmlElement("displayName")]
        public string displayName { get; set; }

        [XmlElement("userCode")]
        public string userCode { get; set; }
        public FriendRemoveRequest()
        {
            Type = Type.Request;
            Action = "FriendRemove";
        }

    }

}