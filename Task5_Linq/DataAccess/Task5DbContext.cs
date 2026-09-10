using Microsoft.EntityFrameworkCore;
using Task5_Linq.Domain.Entities;
using Task5_Linq.Domain.Entities.Mapping;

namespace Task5_Linq.DataAccess
{
    public class Task5DbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer($@"Server=localhost,1435;Database=Task5DBContext;User Id=sa;Password=qelgun2003@;TrustServerCertificate=True").UseLazyLoadingProxies();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CarMap());
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new SaleMap());
        }
    }
}