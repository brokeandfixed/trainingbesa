using Microsoft.AspNetCore.Mvc;
using PT.TrainningBesa04.Models.Dtos;
using PT.TrainningBesa04.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PT.TrainningBesa04.Controllers
{
    [Route("api/contacts")]
    public class ContactsController : Controller
    {
        private IContactsService _service;

        public ContactsController(IContactsService service)
        {
            Console.WriteLine("STOP HERE");
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var contacts = _service.GetAll();
            return Ok(contacts);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var contact = _service.GetById(Guid.Parse(id));
            return Ok(contact);
        }

        [HttpPost]
        public IActionResult Create([FromBody] ContactDto dto)
        {
            _service.Create(dto);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(string id)
        {
            _service.Delete(Guid.Parse(id));
            return Ok();
        }

        [HttpPost]
        public IActionResult Update(ContactDto dto)
        {
            _service.Create(dto);
            return Ok();
        }

    }
}
