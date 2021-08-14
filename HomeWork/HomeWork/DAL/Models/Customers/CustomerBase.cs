using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.DAL.Models.Customers
{
    public class CustomerBase : Person
    {
        private long _id;                   //id заказчика
        private string _nameCustCompany;    //наименование компании заказчика

        /// <summary>Конструктор для создания нового заказчика.</summary>
        /// <param name="firstName">Имя заказчика/ответственного лица.</param>
        /// <param name="secondName">Фамилия заказчика/ответственного лица.</param>
        /// <param name="nameCustCompany">Наименование компании заказчика.</param>
        public CustomerBase(string firstName, string secondName, string nameCustCompany)
            : base(firstName, secondName)
        {
            _nameCustCompany = nameCustCompany;
        }
    }
}
