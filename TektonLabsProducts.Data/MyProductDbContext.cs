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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new ProductConfiguration());
        }
    }
}