using Application_Library;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class CreateGroupRequest : Message
    {
        public List<UserInfo> Users { get; set; } //display name and user code
        public CreateGroupRequest()
        {
            Type = Type.Request;
            Action = "CreateGroup";
        }
    }
}
