using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkiz_Task1.Core.Cust.Interface;
using Tarkiz_Task1.Infrastructure.PracticeDBContext;
using Tarkiz_Task1.Infrastructure.Tables;
using Tarkiz_Task1.Model.Cus;

namespace Tarkiz_Task1.Core.Cust.Implementation
{
    public class BookingCreator : IBookingCreator
    {
        public readonly UserDbContext _userDbContext;
        public BookingCreator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void CreateBooking(BookingRequestModel bookingRequest)
        {
            var booking = new Booking()
            {
                VehicleId = bookingRequest.VehicleId,
                CustomerId = bookingRequest.CustomerId,
                StartingLocation = bookingRequest.StartingLocation,
                EndingLocation = bookingRequest.EndingLocation,
                RentDate = bookingRequest.RentDate,
                ReturnedDate = bookingRequest.ReturnedDate,
            };
            _userDbContext.Booking.Add(booking);
            _userDbContext.SaveChanges();
        }
    }
}
