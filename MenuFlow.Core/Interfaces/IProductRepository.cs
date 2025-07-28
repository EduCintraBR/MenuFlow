using MenuFlow.Core.Entities;

namespace MenuFlow.Core.Interfaces
{
    public interface IProductRepository
    {
        Task<Product?> GetProductsByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Product>> GetAllProductsAsync(CancellationToken cancellationToken = default);

        Task AddAsync(Product product, CancellationToken cancellationToken = default);
        Task UpdateAsync(Product product, CancellationToken cancellationToken = default);
        Task DeleteAsync(Product product, CancellationToken cancellationToken = default);
    }
}
