using Microsoft.EntityFrameworkCore;
using RestApi.Model;


namespace RestApi.Repository
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext()
        {
                
        }


        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers  { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<ProductOrder> ProductOrder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Order>().ToTable("Orders");
            //modelBuilder.Entity<ProductOrder>().ToTable("ProductOrders");

            //modelBuilder.Entity<ProductOrder>()
            // .HasKey(c => new { c.OrderId, c.ProductId });

            base.OnModelCreating(modelBuilder);
        }

    }

 }


