using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class LoginResponseMessage : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        [XmlElement("Info")]
        public UserInfo userInfo { get; set; }

        public LoginResponseMessage()
        {
            Type = Type.Response;
            Action = "Login";
        }

    }

}