﻿using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Chat_Application_Library
{
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

    //public enum UpdateType
    //{
    //    DISPLAY_NAME,
    //    PASSWORD,
    //    AVATAR,
    //    EMAIL
    //}

    public enum ErrorType
    {
        NONE,
        PASSWORD
    }

    [XmlRoot("Message")]
    public abstract class Message
    {
        [JsonProperty("id")]
        [XmlAttribute("id")]
        public string Id              { get; set; }

        [JsonProperty("type")]
        [XmlAttribute("type")]
        public Type Type              { get; set; }

        [JsonProperty("action")]
        [XmlAttribute("action")]
        public string Action          { get; set; }

        [JsonProperty("Client")]
        [XmlElement("Client")]
        public ClientData clientData  { get; set; }
    }

    public class ClientData
    {
        [JsonProperty("id")]
        [XmlAttribute("id")]
        public string Id              { get; set; }

        [JsonProperty("username")]
        [XmlAttribute("username")]
        public string Username        { get; set; }
    }

    public class Result
    {
        [JsonProperty("status")]
        [XmlAttribute("status")]
        public Status Status          { get; set; }
    }

    public class Error
    {
        [JsonProperty("error")]
        [XmlAttribute("error")]
        public ErrorType ErrorType    { get; set; }
    }
}