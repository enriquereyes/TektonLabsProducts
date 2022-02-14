using System.Collections.Generic;
using System.Threading.Tasks;
using TektonLabsProducts.Core;
using TektonLabsProducts.Core.Models;
using TektonLabsProducts.Core.Services;
using TektonLabsProducts.Core.Repositories;
using TektonLabsProducts.Data;
using TektonLabsProducts.Data.Repositories;

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