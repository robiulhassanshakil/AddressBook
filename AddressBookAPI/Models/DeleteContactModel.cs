using AddressBook.SL.Services;
using System;
using System.Threading.Tasks;

namespace AddressBookAPI.Models
{
    public class DeleteContactModel
    {
        private readonly IContactService _contactService;

        public DeleteContactModel()
        {
        }

        public DeleteContactModel(IContactService contactService)
        {
            _contactService = contactService;
        }

        

        public async Task DeleteContactAsync(Guid contactToDeleteId) => 
            await _contactService.DeleteContactAsync(contactToDeleteId);
    }
}
