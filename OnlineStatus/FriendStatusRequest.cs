namespace Chat_Application_Library
{
    public class FriendStatusRequest : Message
    {
        public Result Result { get; set; }

        public string Username { get; set; }

        public FriendStatusRequest()
        {
            Type = Type.Request;
            Action = "Status";
        }
    }
}
