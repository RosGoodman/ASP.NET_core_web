using System;
namespace HomeWork.DAL.Models
{
    public class PersonEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
    }
}
