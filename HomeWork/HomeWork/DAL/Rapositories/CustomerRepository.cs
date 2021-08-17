using HomeWork.DAL.Models;
using HomeWork.Models;
using System;
using System.Collections.Generic;

namespace HomeWork.DAL.Rapositories
{
    public interface ICustomerRepository
    {
        List<HomeWork.Models.Task> GetPrice();
        void RegistrationIndividual(string firstName, string secName);
        void RegistrationLegalEntity(string firstName, string secName, string nameCustComany);
        Contract Request(long idCustomer, List<int> tasks, DateTimeOffset startDate, DateTimeOffset endDate, bool paymentOneTime);
        List<Contract> GetAllContracts(long idCustomer);
        PaymentDetails PaymentData(long idContract);
    }

    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>Получить список контрактов по id.</summary>
        /// <param name="idCustomer">id заказчика.</param>
        /// <returns>Список контрактов.</returns>
        public List<Contract> GetAllContracts(long idCustomer)
        {
            throw new NotImplementedException();
        }

        /// <summary>Получить список услуг.</summary>
        /// <returns>Список услуг.</returns>
        public List<Task> GetPrice()
        {
            throw new NotImplementedException();
        }

        /// <summary>Получить данные для оплаты контракта.</summary>
        /// <param name="idContract">id контракта.</param>
        /// <returns>Данные для оплаты.</returns>
        public PaymentDetails PaymentData(long idContract)
        {
            throw new NotImplementedException();
        }

        /// <summary>Регистация физического лица.</summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="secName">Фамилия.</param>
        public void RegistrationIndividual(string firstName, string secName)
        {
            throw new NotImplementedException();
        }

        /// <summary>Регистрация юр.лица.</summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="secName">Фамилия.</param>
        /// <param name="nameCustComany">Полное наименование компании.</param>
        public void RegistrationLegalEntity(string firstName, string secName, string nameCustComany)
        {
            throw new NotImplementedException();
        }

        /// <summary>Запрос на заключение договора на указанные услуги.</summary>
        /// <param name="idCustomer">id заказчика.</param>
        /// <param name="tasks">Задачи.</param>
        /// <param name="startDate">Дата начала работ.</param>
        /// <param name="endDate">Дата окончания.</param>
        /// <param name="paymentOneTime">Разовая оплата(true), почасовая оплата (false)</param>
        /// <returns>Данные договора.</returns>
        public Contract Request(long idCustomer, List<int> tasks, DateTimeOffset startDate, DateTimeOffset endDate, bool paymentOneTime)
        {
            throw new NotImplementedException();
        }
    }
}
