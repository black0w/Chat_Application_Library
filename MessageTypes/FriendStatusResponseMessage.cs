using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public class FriendStatusResponseMessage : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        public string DisplayName { get; set; }

        public string UserCode { get; set; }

        public bool Status { get; set; }
        public FriendStatusResponseMessage()
        {
            Type = MessageType.Response;
            Action = "Status";
        }

    }

    [XmlRoot("Message")]
    public class FriendStatusRequestMessage : Message
    {

        [XmlElement("Result")]
        public Result Result { get; set; }

        public string Username { get; set; }

        public FriendStatusRequestMessage()
        {
            Type = MessageType.Request;
            Action = "Status";
        }

    }

}