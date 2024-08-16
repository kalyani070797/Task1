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
    public class CustomerCreator : ICustomerCreator
    {
        public readonly UserDbContext _userDbContext;
        public CustomerCreator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void CreateCustomer(CustomerRequestModel customerRequestModel)
        {
            var customer = new Customer()
            {
                FirstName = customerRequestModel.FirstName,
                LastName = customerRequestModel.LastName,
                EmailId = customerRequestModel.EmailId,
                ContactNumber = customerRequestModel.ContactNumber,
                Address = customerRequestModel.Address,
                Dob = customerRequestModel.Dob,
                LicenceNumber = customerRequestModel.LicenceNumber,
                LicenceExpiryDate = customerRequestModel.LicenceExpiryDate,
            };
            _userDbContext.Customer.Add(customer);
            _userDbContext.SaveChanges();
        }
    }
}
