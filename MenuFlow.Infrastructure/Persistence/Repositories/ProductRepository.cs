using MenuFlow.Core.Entities;
using MenuFlow.Core.Interfaces;
using MenuFlow.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;

namespace MenuFlow.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MenuFlowDbContext _context;
        public ProductRepository(MenuFlowDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Product product, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Product product, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Products
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public Task<Product?> GetProductsByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Product product, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
