using System.Xml.Serialization;

namespace Application_Library
{
    /*
      *  <Message type='Request' action='HeartBeat' id='0001'>
      *    <POS id='POS_001'/>
      *  </Message>
      * 
      * <Message type='Response' action='HeartBeat' id='0001'>
      *   <POS id='POS_001'/> 
      *   <Result status='Success'/>
      * </Message>
      * 
      */

    public enum MessageType
    {
        Request,
        MessageRequest,
        Response,
        MessageResponse
    }

    public enum Status
    {
        Success,
        Failure,
        Accept,
        Decline
    }

    [XmlRoot("Message")]
    public abstract class Message
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("type")]
        public MessageType Type { get; set; }

        [XmlAttribute("action")]
        public string Action { get; set; }

        [XmlElement("Client")]
        public ClientData clientData { get; set; }
    }

    public class ClientData
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("username")]
        public string Username { get; set; }
    }

    public class Result
    {
        [XmlAttribute("status")]
        public Status Status { get; set; }
    }
}