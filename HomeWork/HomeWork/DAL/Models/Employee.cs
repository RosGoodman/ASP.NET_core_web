
using HomeWork.DAL.Models;
using System;

namespace HomeWork.Models
{
    /// <summary>Модель, описывающая сотрудника.</summary>
    public class Employee : Person
    {
        private long _employeeID;   //id сотрудника.
        private int _postId;       //должность.

        public Employee(string name, string secName, string gender, DateTime birthday, int postId)
            : base (name, secName, gender, birthday)
        {
            _postId = postId;
        }

        //TODO: удалить потом
        public Employee()
        {
            string name = base.FirstName;
        }
    }
}
