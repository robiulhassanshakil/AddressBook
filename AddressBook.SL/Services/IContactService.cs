using AddressBook.SL.BusinessObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.SL.Services
{
    public interface IContactService
    {
        Task<List<Person>> GetContactsAsync();
        Task CreateCourseAsync(Person person);
    }
}