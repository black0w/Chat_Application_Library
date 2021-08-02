using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class FriendStatusRequest : Message
    {
        public Result Result { get; set; }

        public string Username { get; set; }

        public FriendStatusRequest()
        {
            Type = Type.Request;
            Action = "Status";
        }
    }
}
