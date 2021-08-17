
using HomeWork.DAL.Models.Customers;

namespace HomeWork.DAL.Models
{
    //Модель описывающая реквизиты
    public class PaymentDetails
    {
        //recipient
        private string _fullCompanyName;
        private string _currentAccountNumber;
        private string _nameOfTheBank;
        //private string _correspondentAccount;
        //private string _bic;
        //private string _inn;
        //private string _cpp;
        //private string _cbc;
        //payer
        private CustomerBase _customer;
        private decimal _price;
    }
}
