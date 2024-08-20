using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkiz_Task1.Model.Cus
{
    public class CustomerBookingRequestModel
    {
        public int CustomerId { get; set; }
        public List<BookingModel> BookingRequest { get; set; }
    }
    public class BookingModel
    {
        public int VehicleId { get; set; }
        public string StartingLocation { get; set; }
        public string EndingLocation { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnedDate { get; set; }
    }
}
