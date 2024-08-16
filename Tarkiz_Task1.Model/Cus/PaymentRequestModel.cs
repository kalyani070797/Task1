using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkiz_Task1.Model.Cus
{
    public class PaymentRequestModel
    {
        public int BookingId { get; set; }
      //  public int CustomerId { get; set; }
        public string PaymentModeId { get; set; }
        public string IsPaid { get; set; }
    }
}
