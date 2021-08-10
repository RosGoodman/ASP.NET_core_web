

namespace HomeWork.Models
{
    public class Employee
    {
        private string _firstName;
        private string _secondName;
        private string _company;

        public Employee(string name, string secName, string company)
        {
            _firstName = name;
            _secondName = secName;
            _company = company;
        }
    }
}
