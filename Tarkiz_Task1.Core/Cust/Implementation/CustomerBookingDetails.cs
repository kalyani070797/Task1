using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkiz_Task1.Infrastructure.PracticeDBContext;
using Tarkiz_Task1.Infrastructure.Tables;
using Tarkiz_Task1.Model.Cus;

namespace Tarkiz_Task1.Core.Cust.Implementation
{
    public class CustomerBookingDetails : ICustomerBookingDetails
    {
        public readonly UserDbContext _userDbContext;
        public CustomerBookingDetails(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }

        public void CustomerBooking(CustomerBookingRequestModel customerBooking)
        {
            var Booking = customerBooking.BookingRequest.Select(x => new Booking
            {
                CustomerId = customerBooking.CustomerId,
                VehicleId = x.VehicleId,
                StartingLocation = x.StartingLocation,
                EndingLocation = x.EndingLocation,
                RentDate = x.RentDate,
                ReturnedDate = x.ReturnedDate
            }).ToList();
        
            _userDbContext.Booking.AddRange(Booking);
            _userDbContext.SaveChanges();
        }
    }
}
