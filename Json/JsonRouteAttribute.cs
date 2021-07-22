using Application_Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chat_Application_Library
{
    //[JsonRoute("$.action", "Ping")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class JsonRouteAttribute : RouteAttribute
    {
        public string Value { get; }
        public JsonRouteAttribute(string path, string value)
            : base(path) => Value = value;
    }
}
