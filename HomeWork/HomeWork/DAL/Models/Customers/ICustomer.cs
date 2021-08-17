
using System.Collections.Generic;

namespace HomeWork.DAL.Models.Customers
{
    public interface ICustomer
    {
        Dictionary<string, string> GetPaymentData();
    }
}
