using System.Collections.Generic;
using System.Threading.Tasks;
using AddressBook.SL.BusinessObjects;
using AddressBookAPI.Models;
using Autofac;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AddressBookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger<ContactsController> _logger;

        public ContactsController(ILifetimeScope scope, ILogger<ContactsController> logger)
        {
            _scope = scope;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Person>))]
        public async Task<IActionResult> GetAll()
        {
            var model = _scope.Resolve<ContactListModel>();
            return Ok(await model.GetContactsAsync());
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Person))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Add([FromBody] Person person)
        {
            if (person is null)
                BadRequest("Invalid person");

            var model = _scope.Resolve<CreateCourseModel>();
            await model.CreateCourseAsync(person);

            return Created("TODO", person);
        }






    }
}
