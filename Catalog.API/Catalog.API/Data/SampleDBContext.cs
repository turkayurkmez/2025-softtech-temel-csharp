using Catalog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Catalog.API.Data
{
    public class SampleDBContext : DbContext
    {
        public DbSet<Product>  Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=SofftechSample_DB;Integrated Security=True;Encrypt=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                              .HasMaxLength(250);

            modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(10, 2);


            modelBuilder.Entity<Category>().Property(c => c.Name).IsRequired()
                                                               .HasMaxLength(200);

            modelBuilder.Entity<Product>().HasOne(p => p.Category)
                                          .WithMany(c => c.Products)
                                          .HasForeignKey(p => p.CategoryId)
                                          .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Elektronik" },
                 new Category { Id = 2, Name = "Mobilya" }

            );

            var createdDate = new DateTime(2025, 10, 24, 0, 0, 0);

            modelBuilder.Entity<Product>().HasData(


                new Product { Id = 1, Name = "DELL XPS 15", Price = 500000, CategoryId = 1, Description = "Güçlü bir laptop", CreatedDate = createdDate },

                new Product { Id = 2, Name = "JBL Kulaklık", Price = 3000, CategoryId = 1, Description = "Şık bir kulaklık", CreatedDate = createdDate },
                new Product { Id = 3, Name = "Çalışma koltuğu", Price = 5000, CategoryId = 2, Description = "Koltuk...", CreatedDate = createdDate },
                new Product { Id = 4, Name = "Orta sehpa", Price = 500000, CategoryId = 2, Description = "Sehpa", CreatedDate = createdDate }
            );




        }
    }
}
