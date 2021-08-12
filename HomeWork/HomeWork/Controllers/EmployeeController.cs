
using HomeWork.DAL.Rapositories;
using HomeWork.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

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

        [HttpGet("getAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var result = _repository.GetById(2);

            return StatusCode(200);
        }

        [HttpGet("getEmployeeById")]
        public IActionResult GetEmployeeById(long id)
        {
            var result = _repository.GetById(id);
            return StatusCode(200);
        }

        [HttpPost("name/{name}/secName/{secName}/gender/{gender}/birthday/{birthday}/postId/{postId}")]
        public IActionResult CrateEmployee(string name, string secName, string gender, DateTime birthday, int postId)
        {
            Employee newEmp = new Employee(name, secName, gender, birthday, postId);
            _repository.Create(newEmp);
            return StatusCode(200);
        }
    }
}
