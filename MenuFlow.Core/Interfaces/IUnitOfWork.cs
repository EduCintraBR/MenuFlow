namespace MenuFlow.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get; }
        ITableRepository Tables { get; }
        IOrderRepository Orders { get; }
        IItemOrderRepository ItemOrders { get; }

        Task SaveAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
