using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class LoginRequest : Message
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public LoginRequest()
        {
            Type = Type.Request;
            Action = "Login";
        }
    }
}