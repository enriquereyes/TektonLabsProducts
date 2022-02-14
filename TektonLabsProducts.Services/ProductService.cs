using System.Collections.Generic;
using System.Threading.Tasks;
using TektonLabsProducts.Core;
using TektonLabsProducts.Core.Models;
using TektonLabsProducts.Core.Services;

namespace TektonLabsProducts.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<Product> CreateProduct(Product newProduct)
        {
            await _unitOfWork.Products
                .AddAsync(newProduct);
            
            return newProduct;
        }

        public async Task DeleteProduct(Product Product)
        {
            _unitOfWork.Products.Remove(Product);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task UpdateProduct(Product ProductToBeUpdated, Product Product)
        {
            ProductToBeUpdated.Name = Product.Name;

            await _unitOfWork.CommitAsync();
        }
    }
}