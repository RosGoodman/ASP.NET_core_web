using System;

namespace HomeWork.Models
{
    public class Contract
    {
        private Employee _responsible;
        private long _contractNumber;
        private string _customerCompany;
        private string _customerPersonName;
        private DateTimeOffset _dateOfConclusion;
        private decimal _amount;
        private decimal _prepayment;
        private string _nameOfTheService;

        public Contract()
        {

        }
    }
}
