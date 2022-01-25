using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AddressBook.SL.Contexts;
using AddressBook.SL.Repositories;
using AddressBook.SL.Services;
using AddressBook.SL.UnitOfWorks;
using Autofac;

namespace AddressBook.SL
{
    public class AddressBookSLModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public AddressBookSLModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AddressBookDbContext>().AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName).InstancePerLifetimeScope();

            builder.RegisterType<AddressBookDbContext>().As<IAddressBookDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName).InstancePerLifetimeScope();
            
            builder.RegisterType<PersonRepository>().As<IPersonRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AddressBookUnitOfWork>().As<IAddressBookUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<ContactService>().As<IContactService>().InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
