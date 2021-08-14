
using System.Collections.Generic;

namespace HomeWork.DAL.Models.Customers
{
    public class Individual : CustomerBase
    {
        /// <summary>Конструктор для создания нового заказчика.</summary>
        /// <param name="firstName">Имя заказчика/ответственного лица.</param>
        /// <param name="secondName">Фамилия заказчика/ответственного лица.</param>
        /// <param name="nameCustCompany">Наименование компании заказчика.</param>
        public Individual(string firstName, string secondName)
            : base (firstName, secondName, string.Empty)
        {
        }
    }
}
