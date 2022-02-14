using System.Collections.Generic;
using System.Threading.Tasks;
using TektonLabsProducts.Core.Models;

namespace TektonLabsProducts.Core.Services
{
    public interface IProductService
    {
        //Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(int id);
        Task<Product> CreateProduct(Product newProduct);
        Task UpdateProduct(Product ProductToBeUpdated, Product Product);
        //Task DeleteProduct(Product Product);
    }
}