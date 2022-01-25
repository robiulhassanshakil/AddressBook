using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.SL.BusinessObjects;
using AutoMapper;

namespace AddressBook.SL.Profiles
{
    public class AddressBookSlProfile : Profile
    {
        public AddressBookSlProfile()
        {
            CreateMap<Person, Entities.Person>().ReverseMap();
        }
    }
}
