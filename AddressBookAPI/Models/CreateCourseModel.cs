using AddressBook.SL.BusinessObjects;
using AddressBook.SL.Services;
using System;
using System.Threading.Tasks;

namespace AddressBookAPI.Models
{
    public class CreateCourseModel
    {
        private readonly IContactService _contactService;

        public CreateCourseModel()
        {
        }

        public CreateCourseModel(IContactService contactService)
        {
            _contactService = contactService;
        }

        public async Task CreateCourseAsync(Person person)
        {
            await _contactService.CreateCourseAsync(person);
        }
    }
}
