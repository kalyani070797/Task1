using Tarkiz_Task1.Model;

namespace Tarkiz_Task1.Core.Cust.Implementation
{
    public interface IGetDetails
    {
        List<Detils> Detils(string startingLocation);
    }
}