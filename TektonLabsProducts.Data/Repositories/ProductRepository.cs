using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TektonLabsProducts.Core.Models;
using TektonLabsProducts.Core.Repositories;

namespace TektonLabsProducts.Data.Repositories
{
    public class ProductRepository : IRepository<Product>, IProductRepository
    {
        private MyProductDbContext _context;

        public ProductRepository(MyProductDbContext context)
        {
            _context = context;
        }

        // public ProductRepository(MyProductDbContext context) 
        //     : base(context)
        // { }
        
        public async ValueTask<Product> GetByIdAsync(int id)
        {
            return await MyProductDbContext.Products
                .Include(a => a.Id)
                .SingleOrDefaultAsync(a => a.Id == id);;
        }

        // public async Task<Product> AddAsync(Product product)
        // {
        //     await MyProductDbContext.Products
        //     .AddAsync(product);
        //     return product;  
        //}

        private MyProductDbContext MyProductDbContext
        {
            get { return _context as MyProductDbContext; }
        }
    }
}