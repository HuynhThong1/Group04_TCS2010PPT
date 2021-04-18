using System;

namespace FGW_Management.Models
{
    public class Message
    {
        public int ID { get; set; }
        public string AddedBy { get; set; }
        public string message { get; set; }
        public int GroupId { get; set; }

    }
}
