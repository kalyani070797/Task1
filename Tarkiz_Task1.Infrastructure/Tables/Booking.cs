using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkiz_Task1.Infrastructure.Tables
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string StartingLocation { get; set; }
        public string EndingLocation { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnedDate { get; set; }
    }
}
