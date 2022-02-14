using Microsoft.EntityFrameworkCore;
using TektonLabsProducts.Core.Models;
using TektonLabsProducts.Data.Configurations;

namespace TektonLabsProducts.Data
{
    public class MyProductDbContext : DbContext
    {
        public string DbPath { get; }
        public DbSet<Product> Products { get; set; }

        public MyProductDbContext(DbContextOptions<MyProductDbContext> options)
            : base(options)
        {   
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "products.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new ProductConfiguration());
        }
    }
}