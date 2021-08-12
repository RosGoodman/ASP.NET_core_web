
namespace HomeWork.Models
{
    /// <summary>Модель заказчика.</summary>
    public class Customer
    {
        private long _id;                   //id заказчика
        private bool _juristicPerson;       //юридическое/физическое лицо
        private string _nameCustCompany;    //наименование компании заказчика
        private string _firstName;          //Имя заказчика (физ.лицо/ответственное лицо)
        private string _secondName;         //фамилия заказчика 

        /// <summary>Конструктор для создания нового заказчика.</summary>
        /// <param name="juristicPerson">Юридическое лицо (true), физическое лицо (false)</param>
        /// <param name="nameCustCompany">Наименование компании заказчика.</param>
        /// <param name="firstName">Имя заказчика/ответственного лица.</param>
        /// <param name="secondName">Фамилия заказчика/ответственного лица.</param>
        public Customer(bool juristicPerson, string nameCustCompany, string firstName, string secondName)
        {
            _juristicPerson = juristicPerson;
            _nameCustCompany = nameCustCompany;
            _firstName = firstName;
            _secondName = secondName;
        }

        /// <summary>Конструктор для получения заказчика из БД. (id должно присваиваться БД автоматически)</summary>
        /// <param name="id">id заказчика.</param>
        /// <param name="juristicPerson">Юридическое лицо (true), физическое лицо (false)</param>
        /// <param name="nameCustCompany">Наименование компании заказчика.</param>
        /// <param name="firstName">Имя заказчика/ответственного лица.</param>
        /// <param name="secondName">Фамилия заказчика/ответственного лица.</param>
        public Customer(long id, bool juristicPerson, string nameCustCompany, string firstName, string secondName)
        {
            _id = id;
            _juristicPerson = juristicPerson;
            _nameCustCompany = nameCustCompany;
            _firstName = firstName;
            _secondName = secondName;
        }
    }
}
