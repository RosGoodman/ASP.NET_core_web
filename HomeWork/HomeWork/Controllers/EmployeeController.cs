
using HomeWork.DAL.Rapositories;
using HomeWork.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        [HttpPost("setTaskForEmployee/employeeId/{employeeId}/tasksId/{tasksId}")]
        public IActionResult CrateEmployee(long empliyeeId, List<int> tasksId)
        {
            _repository.SetNewTasksForEmployee(empliyeeId, tasksId);
            return StatusCode(200);
        }

        /// <summary>Отменить задачу.</summary>
        /// <param name="empliyeeId">ID сотрудника.</param>
        /// <param name="taskId">ID задачи.</param>
        /// <returns></returns>
        [HttpPost("removeTaskForEmployee/employeeId/{employeeId}/tasksId/{tasksId}")]
        public IActionResult RemoveEmployeeTask(long empliyeeId, List<int> tasksId)
        {
            _repository.RemoveTaskForEmployee(empliyeeId, tasksId);
            return StatusCode(200);
        }
    }
}
