using System.Collections.Generic;
using System.Threading.Tasks;
using AddressBook.SL.Entities;
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
    }
}
