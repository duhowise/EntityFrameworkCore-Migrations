using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_Migrations
{
    public class EntityMigrationsContext : DbContext
    {
        public DbSet<PaymentOrder> PaymentOrders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=.; Database=EntityMigrationsDemo;Trusted_Connection=True;");
        }

    }
}