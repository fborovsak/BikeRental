using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBikes.Models
{
    public class MessageQueue
    {
        public EventType EventType { get; set; }
        public string Message { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public enum EventType
    {
        BikeRented,
        BikeReturned
    }
}
