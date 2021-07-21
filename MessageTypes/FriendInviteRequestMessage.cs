using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendInviteRequestMessage : Message
    {
        public string username { get; set; }

        public string recipientDisplayName { get; set; }

        public string recipientUserCode { get; set; }

        public FriendInviteRequestMessage()
        {
            Type = MessageType.Request;
            Action = "FriendInvite";
        }
    }
}