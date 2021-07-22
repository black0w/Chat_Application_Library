using Application_Library;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
   public class JsonMessageProtocol : Protocol<JObject>
    {
        protected override JObject Decode(byte[] message)
            => JsonSerialization.Deserialize(Encoding.UTF8.GetString(message));

        protected override byte[] EncodeBody<T>(T message)
            => Encoding.UTF8.GetBytes(JsonSerialization.Serialize(message).ToString());

    }
}
