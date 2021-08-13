using System;

namespace HomeWork.Models
{
    /// <summary>Моель контракта.</summary>
    public class Contract
    {
        private long _id;                       //id контракта
        private long _idCustomer;               //id заказчика
        private DateTimeOffset _contractDate;   //дата заключения контракта
        private string _contractText;           //текст контракта

        /// <summary>Модель для создания контракта.</summary>
        /// <param name="idCustomer">id заказчика.</param>
        /// <param name="_contractDate">Дата заключения контракта.</param>
        /// <param name="contractText">Текст контракта.</param>
        public Contract(long idCustomer, DateTimeOffset contractDate, string contractText)
        {
            _idCustomer = idCustomer;
            _contractDate = contractDate;
            _contractText = contractText;
        }
    }
}
