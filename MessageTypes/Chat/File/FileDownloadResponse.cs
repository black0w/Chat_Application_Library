namespace Chat_Application_Library
{
    public class FileDownloadResponse : Message
    {
        public byte[] FileContent       { get; set; }
        public string FileName          { get; set; }

        public FileDownloadResponse()
        {
            Type = Type.Response;
            Action = "FileDownload";
        }
    }
}