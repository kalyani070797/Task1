using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkiz_Task1.Model.Cus
{
    public class VehicleRequestModel
    {
        public string Brand { get; set; }
        public string Name { get; set; }
        public string LicencePlateNumber { get; set; }
        public string InsuranceNumber { get; set; }
        public DateTime LicenceExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }

    }
}
