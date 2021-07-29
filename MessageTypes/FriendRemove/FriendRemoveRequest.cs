using System.Xml.Serialization;

namespace Chat_Application_Library
{
    public class FriendRemoveRequest : Message
    {
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string UserCode { get; set; }
        public int GroupID { get; set; }
        public FriendRemoveRequest()
        {
            Type = Type.Request;
            Action = "FriendRemove";
        }
    }
}
