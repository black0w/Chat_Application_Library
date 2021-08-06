namespace Chat_Application_Library
{
    public class VoiceCallResponse : Message
    {
        public int GroupID { get; set; }
        public string User { get; set; }
        public VoiceCallResponse()
        {
            Type = Type.Response;
            Action = "VoiceCallResponse";
        }
    }
}