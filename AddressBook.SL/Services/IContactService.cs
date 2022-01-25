using AddressBook.SL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddressBook.SL.Services
{
    public interface IContactService
    {
        Task<List<Person>> GetContactsAsync();
        Task CreateContactAsync(Person person);
        Task DeleteContactAsync(Guid contactToDeleteId);
        Task<Person> GetById(Guid id);
    }
}