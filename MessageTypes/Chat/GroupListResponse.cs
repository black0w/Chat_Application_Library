using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
    [XmlRoot("Message")]
    public class GroupListResponse : Message
    {
        public List<GroupInfo> Groups { get; set; }
        public GroupListResponse()
        {
            Type = Type.Response;
            Action = "GroupList";
        }
    }
}
