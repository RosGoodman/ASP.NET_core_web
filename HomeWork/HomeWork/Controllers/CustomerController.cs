
using HomeWork.DAL.Rapositories;
using HomeWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HomeWork.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        readonly ICustomerRepository _repository;

        public CustomerController(ICustomerRepository repository)
        {
            _repository = repository;
        }

        /// <summary>Получить список услуг.</summary>
        /// <returns>Список услуг.</returns>
        [HttpGet ("getPrice")]
        public IActionResult GetPrice()
        {
            List<Task> price = _repository.GetPrice();
            return Ok(price);
        }

        /// <summary>Зарегистрировать физ.лицо.</summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="secName">Фамилия.</param>
        /// <returns></returns>
        [HttpPost("registrationIndividual/firstName/{firstName}/secName/{secName}")]
        public IActionResult RegistrationIndividual([FromRoute] string firstName, string secName)
        {
            _repository.RegistrationIndividual(firstName, secName);
            return StatusCode(200);
        }

        /// <summary>Зарегистрировать юр.лицо.</summary>
        /// <param name="firstName">Имя.</param>
        /// <param name="secName">Фамилия.</param>
        /// <param name="nameCustCompany">Полное наименование компании.</param>
        /// <returns></returns>
        [HttpPost("registrationLegalEntity/firstName/{firstName}/secName/{secName}/nameCustCompany/{nameCustCompany}")]
        public IActionResult RegistrationIndividual([FromRoute] string firstName, [FromRoute] string secName, [FromRoute] string nameCustCompany)
        {
            _repository.RegistrationLegalEntity(firstName, secName, nameCustCompany);
            return StatusCode(200);
        }

        ///Заявка на работы (отметка необходимых работ, просмотр составленной заявки / договора)
        [HttpPost ("request/")]
        public IActionResult Request()
        {
            return StatusCode(200);
        }

        ///Оплата

        ///Просмотр всех договоров

    }
}
