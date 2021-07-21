using System.Xml.Serialization;

namespace Application_Library
{
   
        [XmlRoot("Message")]
        public class DisplayNameChangeRequestMessage : Message
        {
            public string Username { get; set; }

            public string DisplayName { get; set; }

            public DisplayNameChangeRequestMessage()
            {
                Type = MessageType.Request;
                Action = "DisplayNameChange";
            }
        }
    
}