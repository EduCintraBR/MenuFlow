using MenuFlow.Core.Interfaces;
using MenuFlow.Infrastructure.Persistence.Data;
using MenuFlow.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace MenuFlow.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MenuFlowDbContext _context;
        IDbContextTransaction? _transaction;

        IProductRepository? _productRepository;
        ITableRepository? _tableRepository;
        IOrderRepository? _orderRepository;
        IItemOrderRepository? _itemOrderRepository;

        public UnitOfWork(MenuFlowDbContext context)
        {
            _context = context;
        }

        public IProductRepository Products => _productRepository ??= new ProductRepository(_context);

        public ITableRepository Tables => throw new NotImplementedException();

        public IOrderRepository Orders => throw new NotImplementedException();

        public IItemOrderRepository ItemOrders => throw new NotImplementedException();

        public async Task BeginTransactionAsync()
        {
            _transaction ??= await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _context.SaveChangesAsync();

                await _transaction.CommitAsync();

                await _transaction.DisposeAsync();

                _transaction = null;
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();

                await _transaction.DisposeAsync();

                _transaction = null;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context.Dispose();
        }
    }
}
