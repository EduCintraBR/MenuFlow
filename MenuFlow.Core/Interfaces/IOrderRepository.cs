using MenuFlow.Core.Entities;

namespace MenuFlow.Core.Interfaces
{
    public interface IOrderRepository
    {
        Task<Order?> GetOrdersByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Order>> GetAllOrdersAsync(CancellationToken cancellationToken = default);

        Task AddAsync(Order order, CancellationToken cancellationToken = default);
        Task UpdateAsync(Order order, CancellationToken cancellationToken = default);
        Task DeleteAsync(Order order, CancellationToken cancellationToken = default);
    }
}
