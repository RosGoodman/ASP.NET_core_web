using HomeWork.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork.DAL
{
    public interface IDataContext
    {
        DbSet<Person> Persons { get; set; }
        Task<int> SaveChangeAsync(CancellationToken cancellationToken = default);
    }
}
