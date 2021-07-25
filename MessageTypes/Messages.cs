using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Chat_Application_Library
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

    public enum Type
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
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public Type Type { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("Client")]
        public ClientData clientData { get; set; }
    }

    public class ClientData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class Result
    {
        [JsonProperty("status")]
        public Status Status { get; set; }
    }
}