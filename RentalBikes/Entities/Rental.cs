using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalBikes.Models
{
    public class Rental : BaseEntity
    {
        public string ClientName { get; set; }
        public int BikeId { get; set; }
        public DateTime RentedOn { get; set; }
        public DateTime ExpectedReturn { get; set; }
        public DateTime ReturnedOn { get; set; }
    }
}
