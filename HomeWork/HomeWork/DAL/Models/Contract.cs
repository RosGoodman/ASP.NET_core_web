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
        private bool _paymentOneTime;           //тип оплаты (разовая(true)/почасовая(false))

        /// <summary>Модель для создания контракта.</summary>
        /// <param name="idCustomer">id заказчика.</param>
        /// <param name="_contractDate">Дата заключения контракта.</param>
        /// <param name="contractText">Текст контракта.</param>
        /// <param name="paymentOneTime">Тип оплаты (разовая(true)/почасовая(false)).</param>
        public Contract(long idCustomer, DateTimeOffset contractDate, string contractText, bool paymentOneTime)
        {
            _idCustomer = idCustomer;
            _contractDate = contractDate;
            _contractText = contractText;
            _paymentOneTime = paymentOneTime;
        }
    }
}
