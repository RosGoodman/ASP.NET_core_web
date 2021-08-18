using HomeWork.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
