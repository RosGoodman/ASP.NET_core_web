
using HomeWork.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeWork.DAL
{
    public class DataContext : DbContext , IDataContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
    }
}
