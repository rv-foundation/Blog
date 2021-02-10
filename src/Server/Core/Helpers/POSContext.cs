using Microsoft.EntityFrameworkCore;
using RestroPOS.Entities.Order;
using RestroPOS.Entities.Table;
using RestroPOS.Models.Catalog.Entity;
using RestroPOS.Models.Categories;
using RestroPOS.Models.Users.Entity;

namespace RestroPOS.Models
{
    public class POSContext : DbContext
    {
        public POSContext(DbContextOptions<POSContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Catalogue { get; set; }
        public DbSet<ReservedTable> ReservedTable { get; set; }
        public DbSet<TableItem> TableItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
    }
}
