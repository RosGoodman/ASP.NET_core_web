
using HomeWork.Models;
using System.Collections.Generic;

namespace HomeWork.DAL.Rapositories
{
    public interface IEmployeeRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(long id);
        void Create(T item);
    }

    public class EmployeeRepository : IEmployeeRepository<Employee>
    {
        public void Create(Employee item)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Employee GetById(long id)
        {
            Employee emp = new Employee();
            return emp;
        }
    }
}
