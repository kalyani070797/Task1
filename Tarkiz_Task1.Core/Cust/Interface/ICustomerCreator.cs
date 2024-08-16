using Tarkiz_Task1.Model.Cus;

namespace Tarkiz_Task1.Core.Cust.Interface
{
    public interface ICustomerCreator
    {
        void CreateCustomer(CustomerRequestModel customerRequestModel);
    }
}