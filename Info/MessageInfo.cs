using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Application_Library
{
    [BsonIgnoreExtraElements]
    public class MessageInfo
    {
        [BsonId]
        public Guid Id { set; get; }
        public string SenderDisplayName { get; set; }
        public string SenderUserCode { set; get; }
        public DateTime TimeStamp { get; set; }
        [BsonIgnoreIfDefault, BsonIgnoreIfNull]
        public string SenderAvatar { get; set; }
        public InfoType MessageType { get; set; }
        [BsonIgnoreIfDefault, BsonIgnoreIfNull]
        public byte[] FileContent { get; set; }
        [BsonIgnoreIfDefault, BsonIgnoreIfNull]
        public string FileName { get; set; }
        [BsonIgnoreIfDefault]
        public string Content { get; set; }
    }
}
