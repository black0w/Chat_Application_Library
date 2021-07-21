using System.Xml.Serialization;

namespace Application_Library
{
    [XmlRoot("Message")]
    public enum InfoType
    {
        TEXT,

        FILE,

        IMAGE
    }
}
