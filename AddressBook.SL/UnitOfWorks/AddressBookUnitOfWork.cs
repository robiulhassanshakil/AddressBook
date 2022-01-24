using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.DL;
using AddressBook.SL.Contexts;
using AddressBook.SL.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.SL.UnitOfWorks
{
    public class AddressBookUnitOfWork : UnitOfWork, IAddressBookUnitOfWork
    {
        
        public IPersonRepository Person { get; private set; }

        public AddressBookUnitOfWork(IAddressBookDbContext dbContext,
            IPersonRepository person)
            : base((AddressBookDbContext)dbContext)
        {
            Person = person;
        }
    }
}
