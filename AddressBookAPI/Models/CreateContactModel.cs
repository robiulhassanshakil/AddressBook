using AddressBook.SL.BusinessObjects;
using AddressBook.SL.Services;
using System;
using System.Threading.Tasks;

namespace AddressBookAPI.Models
{
    public class CreateContactModel
    {
        private readonly IContactService _contactService;

        public CreateContactModel()
        {
        }

        public CreateContactModel(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task CreateContactAsync(Person person)
        {
            await _contactService.CreateContactAsync(person);
        }
    }
}
