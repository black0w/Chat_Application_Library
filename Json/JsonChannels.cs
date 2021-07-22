using Application_Library;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
    public class JsonChannel : Channel<JsonMessageProtocol, JObject> { }

    public class JsonClientChannel : ClientChannel<JsonMessageProtocol, JObject> { }
}
