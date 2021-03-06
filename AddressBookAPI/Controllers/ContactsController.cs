using System;
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

            var model = _scope.Resolve<CreateContactModel>();
            await model.CreateContactAsync(person);

            return Created("TODO", person);
        }

        [HttpGet]
        [Route("{contactGetById}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Person))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(Guid contactGetById)
        {
            var model = _scope.Resolve<ContactListModel>();
            var entity = await model.GetById(contactGetById);
            if (entity is null) return NotFound();

            return Ok(entity);
        }

        [HttpDelete]
        [Route("{contactToDeleteId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(Guid contactToDeleteId)
        {
            try
            {
                var model = _scope.Resolve<DeleteContactModel>();
                await model.DeleteContactAsync(contactToDeleteId);
                return Ok();
            }
            catch (ArgumentException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
