using Tarkiz_Task1.Model.Cus;

namespace Tarkiz_Task1.Core.Cust.Implementation
{
    public interface IPaymentCreator
    {
        void CreatePayment(PaymentRequestModel paymentRequest);
    }
}