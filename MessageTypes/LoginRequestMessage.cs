using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class LoginRequestMessage : Message
    {
        public string username { get; set; }

        //   public int Hash { get; set; }

        public string password { get; set; }

        public LoginRequestMessage()
        {
            Type = MessageType.Request;
            Action = "Login";
        }
    }
}