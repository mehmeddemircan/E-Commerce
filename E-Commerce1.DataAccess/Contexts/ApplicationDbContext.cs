using E_Commerce1.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce1.DataAccess.Contexts
{
    public class ApplicationDbContext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=E-Commerce2;User Id=postgres;Password=Sd635241;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductSize>().HasKey(ps => new { ps.ProductId, ps.SizeId });

            modelBuilder.Entity<ProductSize>()
             .HasOne<Product>(sc => sc.Product)
                .WithMany(s => s.ProductSizes)
    .           HasForeignKey(sc => sc.ProductId);


            modelBuilder.Entity<ProductSize>()
             .HasOne<Size>(sc => sc.Size)
                .WithMany(s => s.ProductSizes)
    .HasForeignKey(sc => sc.SizeId);


            modelBuilder.Entity<ProductColor>().HasKey(pc => new { pc.ProductId, pc.ColorId });

            modelBuilder.Entity<ProductColor>()
             .HasOne<Product>(sc => sc.Product)
                .WithMany(s => s.ProductColors)
    .HasForeignKey(sc => sc.ProductId);


            modelBuilder.Entity<ProductColor>()
             .HasOne<Color>(sc => sc.Color)
                .WithMany(s => s.ProductColors)
    .HasForeignKey(sc => sc.ColorId);

        }

        //DbSet Segment
        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<ProductSize> ProductSizes { get; set; }


        public DbSet<Color> Colors { get; set; }

        public DbSet<ProductColor> ProductColors { get; set; }

        public DbSet<Model> Models { get; set; }

    }
}
