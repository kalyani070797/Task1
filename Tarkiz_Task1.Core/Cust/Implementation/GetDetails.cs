using Azure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarkiz_Task1.Infrastructure.PracticeDBContext;
using Tarkiz_Task1.Infrastructure.Tables;
using Tarkiz_Task1.Model;

namespace Tarkiz_Task1.Core.Cust.Implementation
{
    public class GetDetails : IGetDetails
    {
        public readonly UserDbContext _dbContext;
        public GetDetails(UserDbContext userDbContext)
        {
            _dbContext = userDbContext;
        }
        //public List<Detils> Detils(string startingLocation)
        //{
        //    var customers = _dbContext.Booking
        //        .Where(b => b.StartingLocation == startingLocation)
        //        .Select(b => new Detils
        //        {
        //            CustomerId = b.Customer.CustomerId,  // Ensure this matches the clas
        //            FirstName = b.Customer.FirstName,
        //            LastName = b.Customer.LastName,
        //            EmailId = b.Customer.EmailId,
        //            ContactNumber = b.Customer.ContactNumber,
        //            Address = b.Customer.Address,
        //            Dob = b.Customer.Dob,
        //            LicenceNumber = b.Customer.LicenceNumber,
        //            LicenceExpiryDate = b.Customer.LicenceExpiryDate,
        //            VehicleId = b.Vehicle.VehicleId,
        //            Brand = b.Vehicle.Brand,
        //            Name = b.Vehicle.Name,
        //            LicencePlateNumber = b.Vehicle.LicencePlateNumber
        //        })
        //        .ToList();

        //    return customers;
        //}

        public List<Detils> Detils(string startingLocation)
        {
            var customers = (from booking in _dbContext.Booking
                             join customer in _dbContext.Customer on booking.CustomerId equals customer.CustomerId
                             join vehicle in _dbContext.Vehicle on booking.VehicleId equals vehicle.VehicleId
                             where booking.StartingLocation == startingLocation
                             select new Detils
                             {
                                 CustomerId = customer.CustomerId,
                                 FirstName = customer.FirstName,
                                 StartingLocation = booking.StartingLocation,
                                 LastName = customer.LastName,
                                 EmailId = customer.EmailId,
                                 ContactNumber = customer.ContactNumber,
                                 Address = customer.Address,
                                 Dob = customer.Dob,
                                 LicenceNumber = customer.LicenceNumber,
                                 LicenceExpiryDate = customer.LicenceExpiryDate,
                                 VehicleId = vehicle.VehicleId,
                                 Brand = vehicle.Brand,
                                 Name = vehicle.Name,
                                 LicencePlateNumber = vehicle.LicencePlateNumber
                             })
                            .ToList();

            return customers;
        }

    }
}
