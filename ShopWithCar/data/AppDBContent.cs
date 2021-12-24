using Microsoft.EntityFrameworkCore;
using ShopWithCar.data.Models;

namespace ShopWithCar.Data
{
    public class AppDBContent : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShopCarItem> ShopCarItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
    }
}
