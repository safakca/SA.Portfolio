using System;

namespace SA.Portfolio.Models
{
    public class Message : BaseEntity
    {
        public string SenderMail { get; set; }
        public string SenderName { get; set; }
        public string SenderSurname { get; set; }
        public string ReceiverMail { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverSurname { get; set; }
        public DateTime MessageDate { get; set; }
        public string MessageSubject { get; set; }
        public string MessageContent { get; set; }
    }
}