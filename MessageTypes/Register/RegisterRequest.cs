using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class RegisterRequest : Message
    {
        public string Username { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public RegisterRequest()
        {
            Type = Type.Request;
            Action = "Register";
        }
    }
}