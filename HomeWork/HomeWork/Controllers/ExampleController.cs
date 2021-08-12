using HomeWork.Models;
using HomeWork.Repositoryes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<int> GetNumbers()
        {
            return null;
        }
    }

    //[Route("/api/employye")]
    //public class EmployeeController
    //{
    //    [HttpGet("/")]
    //    public IEnumerable<int> Get()
    //    {
    //        return Enumerable.Range(0, 100);
    //    }

    //    [HttpPost("name/{name}/secName/{secName}/company/{company}")]
    //    public Employee Create([FromRoute] string name, [FromRoute] string secName, [FromRoute] string company)
    //    {
    //        return new Employee(name, secName, company);
    //    }
    //}

    [Route("/api/contract")]
    public class ContractController
    {
        [HttpGet("/getContracts")]
        public IEnumerable<int> Get()
        {
            return Enumerable.Range(0, 100);
        }

        [HttpPost("/{id}/task")]
        public int AddTask([FromRoute] string task)
        {
            return -1;
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
