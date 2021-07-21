using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendListRequestMessage : Message
    {
        public string username { get; set; }

       
        public FriendListRequestMessage()
        {
            Type = Type.Request;
            Action = "FriendList";
        }
    }
}