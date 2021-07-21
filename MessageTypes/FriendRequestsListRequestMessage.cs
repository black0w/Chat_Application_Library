using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendRequestsListRequestMessage : Message
    {
        public string username { get; set; }


        public FriendRequestsListRequestMessage()
        {
            Type = Type.Request;
            Action = "FriendRequestsList";
        }
    }
}