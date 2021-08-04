using System;

namespace Chat_Application_Library
{
    public class FileDownloadRequest : Message
    {
        public string FileName              { get; set; }
        public string Username              { get; set; }
        public string SenderDisplayName     { get; set; }
        public string SenderUserCode        { get; set; }
        public int GroupID                  { get; set; }
        public DateTime TimeStamp           { get; set; }
        public FileDownloadRequest()
        {
            Type = Type.Request;
            Action = "FileDownload";
        }
    }
}