using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.DL;
using AddressBook.SL.Contexts;
using AddressBook.SL.Entities;

namespace AddressBook.SL.Repositories
{
    public class PersonRepository : Repository<Person, Guid, AddressBookDbContext>, IPersonRepository
    {
        public PersonRepository(AddressBookDbContext context) 
            : base(context)
        {

        }
    } 
}
