using Application_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
    public class FileMessageRequest : Message
    {
        public string SenderDisplayName      { get; set; }
        public string SenderUserCode         { get; set; }
        public int GroupID                   { get; set; }
        public string FileName               { get; set; }
        public byte[] FileContent            { get; set; }
        public InfoType MessageType          { get; set; }
        public DateTime TimeStamp            { get; set; }

        public FileMessageRequest()
        {
            Type = Type.Request;
            Action = "FileMessage";
        }
    }
}