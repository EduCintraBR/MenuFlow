using MenuFlow.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace MenuFlow.Infrastructure.Persistence.Data
{
    public class MenuFlowDbContext : DbContext
    {
        public MenuFlowDbContext(DbContextOptions<MenuFlowDbContext> options) : base(options) { }

        public DbSet<ItemOrder> ItemsOrders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
