
using HomeWork.DAL.Models;
using System;

namespace HomeWork.Models
{
    /// <summary>Модель, описывающая сотрудника.</summary>
    public class Employee : Person
    {
        private long _employeeID;   //id сотрудника.
        private string _post;       //должность.

        public Employee(string post, string name, string secName, string gender, DateTime birthday)
            : base(name, secName, gender, birthday)
        {
            _post = post;
        }
    }
}
