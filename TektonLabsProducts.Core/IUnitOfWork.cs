using System;
using System.Threading.Tasks;
using TektonLabsProducts.Core.Repositories;

namespace TektonLabsProducts.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get;}
        Task<int> CommitAsync();
    }
}