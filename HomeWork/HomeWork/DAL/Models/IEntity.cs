﻿

using System;

namespace HomeWork.DAL.Models
{
    public interface IEntity
    {
        Guid Id { get; set; }
        bool IsActive { get; set; }
        DateTime DateCreated { get; set; }
        DateTime? DateUpdated { get; set; }
        Guid UserCreated { get; set; }
        Guid? UserUpdated { get; set; }
    }
}
