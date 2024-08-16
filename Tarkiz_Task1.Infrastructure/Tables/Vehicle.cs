﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkiz_Task1.Infrastructure.Tables
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string LicencePlateNumber { get; set; }
        public string InsuranceNumber { get; set; }
        public DateTime LicenceExpiryDate { get; set; }
        public bool IsActive { get; set; }
        [Precision(18,2)]
        public decimal Price { get; set; }
    }
}
