using System;

namespace HomeWork.DAL.Models
{
    /// <summary>Модель, описывающая отдельного человека.</summary>
    public class Person
    {
        private string _firstName;  //имя сотрудника.
        private string _secondName; //фамилия сотрудника.
        private string _gender;     //пол
        private DateTime _birthday; //дата рождения.

        public Guid Id { get; set; }

        public string FirstName
        {
            get { return _firstName; }
        }

        public Person(string name, string secName, string gender, DateTime birthday)
        {
            _firstName = name;
            _secondName = secName;
            _gender = gender;
            _birthday = birthday;
        }

        public Person(string name, string secName)
        {
            _firstName = name;
            _secondName = secName;
        }

        //TODO: удалить потом
        public Person()
        {
            _firstName = "Ivan";
        }
    }
}
