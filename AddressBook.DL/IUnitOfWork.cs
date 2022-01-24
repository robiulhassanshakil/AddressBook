using System;
using System.Threading.Tasks;

namespace AddressBook.DL
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();

        Task SaveAsync();
    }
}
