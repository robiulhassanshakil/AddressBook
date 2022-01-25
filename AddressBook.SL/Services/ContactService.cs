using AddressBook.SL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.SL.UnitOfWorks;
using AutoMapper;

namespace AddressBook.SL.Services
{
    public class ContactService : IContactService
    {
        private readonly IAddressBookUnitOfWork _addressBookUnitOfWork;
        private readonly IMapper _mapper;

        public ContactService()
        {
            
        }

        public ContactService(IAddressBookUnitOfWork addressBookUnitOfWork,IMapper mapper)
        {
            _addressBookUnitOfWork = addressBookUnitOfWork;
            _mapper = mapper;
        }

        public async Task<List<Person>> GetContactsAsync()
        {
            var entityList = await _addressBookUnitOfWork.Person.GetAllAsync();
            var person = new List<Person>();
            return (_mapper.Map(entityList, person));
        }
    }
}
