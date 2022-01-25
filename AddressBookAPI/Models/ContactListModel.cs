

using System.Collections.Generic;
using System.Threading.Tasks;
using AddressBook.SL.BusinessObjects;
using AddressBook.SL.Services;

namespace AddressBookAPI.Models
{
    public class ContactListModel
    {
        private readonly IContactService _contactService;

        public ContactListModel()
        {
        }

        public ContactListModel(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task<List<Person>> GetContactsAsync() => await _contactService.GetContactsAsync();
    }
}
