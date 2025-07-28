using MenuFlow.Core.Entities;

namespace MenuFlow.Core.Interfaces
{
    public interface ITableRepository
    {
        Task<Table?> GetTableByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Table>> GetAllTablesAsync(CancellationToken cancellationToken = default);
        
        Task AddAsync(Table table, CancellationToken cancellationToken = default);
        Task UpdateAsync(Table table, CancellationToken cancellationToken = default);
        Task DeleteAsync(Table table, CancellationToken cancellationToken = default);
    }
}
