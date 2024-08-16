using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkiz_Task1.Infrastructure.Tables
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public Booking Booking { get; set; }
        //public int CustomerId { get; set; }
        //public Customer Customer { get; set; }
        public string PaymentModeId { get; set; }
        public string IsPaid { get; set; }
    }
}
