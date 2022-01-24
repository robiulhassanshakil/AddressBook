
using AddressBook.SL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AddressBook.SL.Contexts
{
    public class AddressBookDbContext : DbContext, IAddressBookDbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        public AddressBookDbContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

         DbSet<Person> Persons { get; set; }
    }
}
