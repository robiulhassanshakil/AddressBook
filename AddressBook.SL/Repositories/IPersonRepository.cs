using System;
using AddressBook.DL;
using AddressBook.SL.Contexts;
using AddressBook.SL.Entities;

namespace AddressBook.SL.Repositories
{
    public interface IPersonRepository : IRepository<Person, Guid, AddressBookDbContext>
    {
    }
}