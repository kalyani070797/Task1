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
    public class VehicleCreator : IVehicleCreator
    {
        public readonly UserDbContext _userDbContext;
        public VehicleCreator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void CreateVehicle(VehicleRequestModel vehicleRequest)
        {
            var vehicle = new Vehicle()
            {
                Brand = vehicleRequest.Brand,
                Name = vehicleRequest.Name,
                LicencePlateNumber = vehicleRequest.LicencePlateNumber,
                InsuranceNumber = vehicleRequest.InsuranceNumber,
                LicenceExpiryDate = vehicleRequest.LicenceExpiryDate,
                IsActive = vehicleRequest.IsActive,
                Price = vehicleRequest.Price,

            };
            _userDbContext.Vehicle.Add(vehicle);
            _userDbContext.SaveChanges();
        }
    }
}
