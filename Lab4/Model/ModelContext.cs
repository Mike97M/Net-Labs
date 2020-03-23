using Microsoft.EntityFrameworkCore;

namespace Lab4.Model
{
    public class ModelContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-G8C8J29\SQLEXPRESS01;Database=EFCore2020;Trusted_Connection=True");
        //ChangeTracker.LazyLoadingEnabled = false;
 }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
            .HasMany<Order>(o => o.Orders)
            .WithOne(c => c.Client);

            modelBuilder.Entity<OrderDetail>()
            .HasOne<Order>(od => od.Order)
            .WithMany(o => o.OrderDetails);
            modelBuilder.Entity<Product>()
            .HasMany<OrderDetail>(p => p.OrderDetails)
            .WithOne(od => od.Product);
        }
    }

}
