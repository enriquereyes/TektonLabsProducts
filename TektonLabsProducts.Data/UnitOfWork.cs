using System.Threading.Tasks;
using TektonLabsProducts.Core;
using TektonLabsProducts.Core.Repositories;
using TektonLabsProducts.Data.Repositories;

namespace TektonLabsProducts.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MyProductDbContext _context;
        private ProductRepository _ProductRepository;

        public UnitOfWork(MyProductDbContext context)
        {
            this._context = context;
        }

        public IProductRepository Products => _ProductRepository = _ProductRepository ?? new ProductRepository(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}