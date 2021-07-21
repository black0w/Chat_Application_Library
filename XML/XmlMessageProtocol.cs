using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Application_Library
{
    public class XmlMessageProtocol : Protocol<XDocument>
    {
        protected override XDocument Decode(byte[] message)
        {
            var xmlData = Encoding.UTF8.GetString(message);
            //Console.WriteLine(xmlData);
            var xmlReader = XmlReader.Create(new StringReader(xmlData), new XmlReaderSettings { DtdProcessing = DtdProcessing.Ignore });
            return XDocument.Load(xmlReader);
        }

        protected override byte[] EncodeBody<T>(T message)
        {
            if (message is XDocument)
                return Encoding.UTF8.GetBytes(message.ToString());
            else
                return Encoding.UTF8.GetBytes(XmlSerialization.Serialize(message).ToString());
        }
    }
}
