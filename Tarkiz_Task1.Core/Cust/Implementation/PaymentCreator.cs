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
    public class PaymentCreator : IPaymentCreator
    {
        public readonly UserDbContext _userDbContext;
        public PaymentCreator(UserDbContext userDbContext)
        {
            _userDbContext = userDbContext;
        }
        public void CreatePayment(PaymentRequestModel paymentRequest)
        {
            var payment = new Payment()
            {
                BookingId = paymentRequest.BookingId,
                PaymentModeId = paymentRequest.PaymentModeId,
                IsPaid = paymentRequest.IsPaid,
            };
            _userDbContext.Payment.Add(payment);
            _userDbContext.SaveChanges();
        }
    }
}
