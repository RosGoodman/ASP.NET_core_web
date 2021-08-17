using HomeWork.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.DAL
{
    public class DataContext : DbContext
    {
        public DbSet<PersonEntity> Persons { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        public DbSet<T> DbSet<T>() where T : class
        {
            return Set<T>();
        }

        public new IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }
    }
}
