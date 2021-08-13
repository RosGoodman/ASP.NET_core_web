
using HomeWork.DAL.Rapositories;
using HomeWork.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HomeWork.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository<Employee> _repository;

        public EmployeeController(IEmployeeRepository<Employee> repository)
        {
            _repository = repository;
        }

        /// <summary>Получить текущие данные и задачи сотрудника.</summary>
        /// <param name="id">id сотрудника.</param>
        /// <returns>Список задач.</returns>
        [HttpGet("getById/id/{id}")]
        public IActionResult GetById(long id)
        {
            var result = _repository.GetById(id);
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

        /// <summary>Отменить задачу.</summary>
        /// <param name="empliyeeId">ID сотрудника.</param>
        /// <param name="taskId">ID задачи.</param>
        /// <returns></returns>
        [HttpPost("removeTaskForEmployee/employeeId/{employeeId}/taskId/{taskId}")]
        public IActionResult RemoveEmployeeTask(long empliyeeId, int taskId)
        {
            _repository.RemoveTaskForEmployee(empliyeeId, taskId);
            return StatusCode(200);
        }
    }
}
