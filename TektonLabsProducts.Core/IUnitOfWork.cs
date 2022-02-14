using System;
using System.Threading.Tasks;
using TektonLabsProducts.Core.Repositories;

namespace MyMusic.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Product { get;}
        Task<int> CommitAsync();
    }
}