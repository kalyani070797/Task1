using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkiz_Task1.Model.Cus
{
    public class CustomerRequestModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }
        public string LicenceNumber { get; set; }
        public DateTime LicenceExpiryDate { get; set; }
    }
}
