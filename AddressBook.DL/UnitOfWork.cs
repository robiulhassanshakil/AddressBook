using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AddressBook.DL
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext DbContext;

        public UnitOfWork(DbContext dbContext) => DbContext = dbContext;

        public void Dispose() => DbContext?.Dispose();

        public void Save() => DbContext?.SaveChanges();

        public async Task SaveAsync() => await DbContext.SaveChangesAsync();
        
    }
}
