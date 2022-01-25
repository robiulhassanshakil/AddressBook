using AddressBook.DL;
using AddressBook.SL.Contexts;
using AddressBook.SL.Repositories;
using Microsoft.EntityFrameworkCore;


namespace AddressBook.SL.UnitOfWorks
{
    public class AddressBookUnitOfWork : UnitOfWork, IAddressBookUnitOfWork
    {
        
        public IPersonRepository Persons { get; private set; }

        public AddressBookUnitOfWork(AddressBookDbContext dbContext,
            IPersonRepository persons)
            : base(dbContext)
        {
            Persons = persons;
        }
    }
}
