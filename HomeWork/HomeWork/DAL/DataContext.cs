using HomeWork.DAL.Models;
using System.Data.Entity;

namespace HomeWork.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
