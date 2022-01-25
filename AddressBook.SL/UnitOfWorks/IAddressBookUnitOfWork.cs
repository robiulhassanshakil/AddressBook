using System.Dynamic;
using AddressBook.DL;
using AddressBook.SL.Contexts;
using AddressBook.SL.Repositories;

namespace AddressBook.SL.UnitOfWorks
{
    public interface IAddressBookUnitOfWork : IUnitOfWork
    {
        IPersonRepository Persons { get; }
    }
}