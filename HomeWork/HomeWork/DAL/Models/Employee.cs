
using System;

namespace HomeWork.Models
{
    /// <summary>Модель, описывающая сотрудника.</summary>
    public class Employee
    {
        private string _firstName;  //имя сотрудника.
        private string _secondName; //фамилия сотрудника.
        private string _gender;     //пол
        private DateTime _birthday; //дата рождения.

        private long _employeeID;   //id сотрудника.
        private int _postId;       //должность.

        public string FirstName
        {
            get { return _firstName; }
        }

        public Employee(string name, string secName, string gender, DateTime birthday, int postId)
        {
            _firstName = name;
            _secondName = secName;
            _gender = gender;
            _birthday = birthday;

            _postId = postId;
        }

        //TODO: удалить потом
        public Employee()
        {
            _firstName = "Ivan";
        }
    }
}
