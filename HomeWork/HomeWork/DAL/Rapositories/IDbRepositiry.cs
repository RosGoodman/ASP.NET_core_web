using HomeWork.DAL.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.DAL.Rapositories
{
    public interface IDbRepositiry
    {
        //получение сущностей
        //IQueryable<T> Get<T>(Expression<Func<T, bool>> selector) where T : class, IEntity;
        IQueryable<T> Get<T>() where T : class, IEntity;
        IQueryable<T> GetAll<T>() where T : class, IEntity;
        //добавление сущностей
        Task<Guid> Add<T>(T newEntity) where T : class, IEntity;
        Task Delete<T>(Guid entity) where T : class, IEntity;
        Task Remove<T>(T entity) where T : class, IEntity;
        Task Update<T>(T entity) where T : class, IEntity;
        //Task<int> SaveRangeAsync();
    }
}
