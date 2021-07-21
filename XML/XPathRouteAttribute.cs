using System;

namespace Application_Library
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class XPathRouteAttribute : RouteAttribute
    {
        public XPathRouteAttribute(string path) : base(path) { }
    }
}
