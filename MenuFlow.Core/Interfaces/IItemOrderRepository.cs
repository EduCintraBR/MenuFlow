using MenuFlow.Core.Entities;

namespace MenuFlow.Core.Interfaces
{
    public interface IItemOrderRepository
    {
        Task<ItemOrder?> GetItemOrderByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<ItemOrder>> GetAllItemsOrdersByOrderAsync(Guid orderId, CancellationToken cancellationToken = default);

        Task AddAsync(ItemOrder itemOrder, CancellationToken cancellationToken = default);
        Task UpdateAsync(ItemOrder itemOrder, CancellationToken cancellationToken = default);
        Task DeleteAsync(ItemOrder itemOrder, CancellationToken cancellationToken = default);
    }
}
