using System;

namespace HomeWork.DAL.Models
{
    /// <summary>Модель, описывающая человека.</summary>
    public class Person
    {
        private string _firstName;  //имя сотрудника.
        private string _secondName; //фамилия сотрудника.
        private string _gender;     //пол
        private DateTime _birthday; //дата рождения.

        public Person(string name, string secName, string gender, DateTime birthday)
        {
            _firstName = name;
            _secondName = secName;
            _gender = gender;
            _birthday = birthday;
        }
    }
}
