using HomeWork.Models;
using HomeWork.Repositoryes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController
    {
        [HttpGet]
        public IEnumerable<int> GetNumbers()
        {
            return Enumerable.Range(0, 100);
        }
    }

    [Route("/api/employye")]
    public class EmployeeController
    {
        [HttpGet("/")]
        public IEnumerable<int> Get()
        {
            return Enumerable.Range(0, 100);
        }

        [HttpPost("name/{name}/secName/{secName}/company/{company}")]
        public Employee Create([FromRoute] string name, [FromRoute] string secName, [FromRoute] string company)
        {
            return new Employee(name, secName, company);
        }
    }

    [Route("/api/contract")]
    public class ContractController
    {
        [HttpGet("/")]
        public IEnumerable<int> Get()
        {
            return Enumerable.Range(0, 100);
        }

        [HttpPost("/{id}/task")]
        public void AddTask([FromRoute] Task task)
        {
            //add
        }

        [HttpGet("/contract/{id}")]
        public IActionResult GetContract([FromRoute] long id)
        {
            var repository = new ContractRepository();
            Contract cont = repository.GetContractById(id);
            return (IActionResult)cont;
        }
    }
}
