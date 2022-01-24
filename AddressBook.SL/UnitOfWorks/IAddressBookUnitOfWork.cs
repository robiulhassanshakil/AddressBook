using System.Dynamic;
using AddressBook.DL;
using AddressBook.SL.Repositories;

namespace AddressBook.SL.UnitOfWorks
{
    public interface IAddressBookUnitOfWork : IUnitOfWork
    {
        IPersonRepository Person { get; }
    }
}