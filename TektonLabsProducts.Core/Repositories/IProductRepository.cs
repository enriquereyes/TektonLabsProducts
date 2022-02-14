using System.Collections.Generic;
using System.Threading.Tasks;
using TektonLabsProducts.Core.Models;

namespace TektonLabsProducts.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        ValueTask<Product> GetByIdAsync(int id);
    }
}