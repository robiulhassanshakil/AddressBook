using AddressBook.SL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.SL.UnitOfWorks;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace AddressBook.SL.Services
{
    public class ContactService : IContactService
    {
        private readonly IAddressBookUnitOfWork _addressBookUnitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<ContactService> _logger;

        public ContactService()
        {

        }

        public ContactService(IAddressBookUnitOfWork addressBookUnitOfWork, IMapper mapper, ILogger<ContactService> logger)
        {
            _addressBookUnitOfWork = addressBookUnitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<Person>> GetContactsAsync()
        {
            var entityList = await _addressBookUnitOfWork.Persons.GetAllAsync();
            var person = new List<Person>();
            return (_mapper.Map(entityList, person));
        }

        public async Task CreateCourseAsync(Person person)
        {
            var entity = _mapper.Map<Entities.Person>(person);
            await _addressBookUnitOfWork.Persons.AddAsync(entity);
            await _addressBookUnitOfWork.SaveAsync();

            
        }
    }
}
