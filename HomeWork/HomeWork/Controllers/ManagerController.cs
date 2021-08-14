using HomeWork.DAL.Rapositories;
using HomeWork.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HomeWork.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IEmployeeRepository<Employee> _repository;

        public ManagerController(IEmployeeRepository<Employee> repository)
        {
            _repository = repository;
        }

        /// <summary>Получить список всех сотрудников.</summary>
        /// <returns>Список сотрудников.</returns>
        [HttpGet("getAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var result = _repository.GetById(2);

            return StatusCode(200);
        }

        /// <summary>Получить данные сотрудника по ID.</summary>
        /// <param name="id">ID сотрудника.</param>
        /// <returns>Данные сотрудника.</returns>
        [HttpGet("getEmployeeById/id/{id}")]
        public IActionResult GetEmployeeById([FromRoute] long id)
        {
            var result = _repository.GetById(id);
            return StatusCode(200);
        }

        /// <summary>Создать нового сотрудника.</summary>
        /// <param name="name">Имя.</param>
        /// <param name="secName">Фамилия.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="birthday">Дата рождения.</param>
        /// <param name="postId">ID должности.</param>
        /// <returns></returns>
        [HttpPost("createEmployee/name/{name}/secName/{secName}/gender/{gender}/birthday/{birthday}/postId/{postId}")]
        public IActionResult CrateEmployee(string name, string secName, string gender, DateTime birthday, int postId)
        {
            Employee newEmp = new Employee(name, secName, gender, birthday, postId);
            _repository.Create(newEmp);
            return StatusCode(200);
        }

        /// <summary>Установить новую задачу для сотрудника.</summary>
        /// <param name="empliyeeId">ID сотрудника.</param>
        /// <param name="taskId">ID задачи.</param>
        /// <returns></returns>
        [HttpPost("setTaskForEmployee/employeeId/{employeeId}/taskId/{taskId}")]
        public IActionResult CrateEmployee(long empliyeeId, int taskId)
        {
            _repository.SetNewTaskForEmployee(empliyeeId, taskId);
            return StatusCode(200);
        }

        ///Создать должность

        ///Просмотр заявок клинтов

        ///Заключить договор по №заявки

        ///Отметить окончание работ, отправка данных (работы, итоговый счет)
        
        ///Закрытие договора (своевременное / досрочное)
        
        ///Отчет по задаче
        
        ///Отчет по инвойсу

        
    }
}
