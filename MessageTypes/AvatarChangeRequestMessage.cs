using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public partial class AvatarChangeRequestMessage : Message
    {
        public string username { get; set; }

        public string imgURL { get; set; }

        public AvatarChangeRequestMessage()
        {
            Type = MessageType.Request;
            Action = "AvatarChange";
        }
    }
}