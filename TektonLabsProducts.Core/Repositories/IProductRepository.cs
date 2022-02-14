using System.Collections.Generic;
using System.Threading.Tasks;
using TektonLabsProducts.Core.Models;

namespace TektonLabsProducts.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        ValueTask<Product> GetByIdAsync(int id);
        // Task<IEnumerable<Product>> GetAllAsync();
        //Task AddAsync(Product entity);
        // Task AddRangeAsync(IEnumerable<Product> entities);
        // void Remove(Product entity);
        // void RemoveRange(IEnumerable<Product> entities);
    }
}