using System.Xml.Linq;

namespace Application_Library
{

    //helper classes, do nothing , just helping us by letting us write less (their names are long)
    public class XmlChannel : Channel<XmlMessageProtocol, XDocument> { }

    public class XmlClientChannel : ClientChannel<XmlMessageProtocol, XDocument> { }
}
