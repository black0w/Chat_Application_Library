using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class RegisterRequestMessage : Message
    {
        public string username { get; set; }

        public string displayName { get; set; }

        public string email { get; set; }


        public string password { get; set; }

        public RegisterRequestMessage()
        {
            Type = Type.Request;
            Action = "Register";
        }
    }
}