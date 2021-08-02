using Application_Library;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class LoginResponse : Message
    {
        public Result Result        { get; set; }

        public UserInfo userInfo    { get; set; }

        public LoginResponse()
        {
            Type = Type.Response;
            Action = "Login";
        }
    }
}