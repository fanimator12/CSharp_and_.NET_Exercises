using System;

namespace Server
{
    public class Message
    {
        public string Body { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Sender { get; set; }
    }
}