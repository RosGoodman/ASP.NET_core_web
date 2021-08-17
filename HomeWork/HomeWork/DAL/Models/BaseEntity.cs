using System;

namespace HomeWork.DAL.Models
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public Guid UserCreated { get; set; }
        public Guid? UserUpdated { get; set; }
    }
}
