
using HomeWork.Models;
using System.Collections.Generic;

namespace HomeWork.DAL.Rapositories
{
    public interface IEmployeeRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(long id);
        void Create(T item);
        void SetNewTasksForEmployee(long empliyeeId, List<int> taskId);
        void RemoveTaskForEmployee(long empliyeeId, List<int> taskId);
    }

    public class EmployeeRepository : IEmployeeRepository<Employee>
    {
        /// <summary>Создать нового сотрудника.</summary>
        /// <param name="item">Сотрудник.</param>
        public void Create(Employee item)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>Получить список сотрудников.</summary>
        /// <returns>Список сотрудников.</returns>
        public List<Employee> GetAll()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>Получить сотрудника по ID.</summary>
        /// <param name="empliyeeId">ID сотрудника.</param>
        /// <param name="taskId">ID задачи.</param>
        public Employee GetById(long id)
        {
            throw new System.NotImplementedException();
            Employee emp = new Employee();
            return emp;
        }

        /// <summary>Установить новую задачу для сотрудника.</summary>
        /// <param name="empliyeeId">ID сотрудника.</param>
        /// <param name="tasksId">ID задачи.</param>
        public void SetNewTasksForEmployee(long empliyeeId, List<int> tasksId)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>Отменить задачу сотрудника.</summary>
        /// <param name="empliyeeId">ID сотрудника.</param>
        /// <param name="tasksId">ID задачи.</param>
        public void RemoveTaskForEmployee(long empliyeeId, List<int> tasksId)
        {
            throw new System.NotImplementedException();
        }
    }
}
