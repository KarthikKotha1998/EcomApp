using System;
using EcomApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EcomApp.DataAccess.Data
{
	public class ApplicationDbContext:IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
		{

		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=EcomApp;User Id=SA;Password=Karthik@98;Encrypt=False;TrustServerCertificate=True");
            }
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Action", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "History", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Harry Potter",
                        Author = "Gosling",
                        Description = "Famous book which was made into a movie.",
                        ISBN = "SWD0999990L",
                        ListPrice = 99,
                        Price = 90,
                        Price50 = 85,
                        Price100 = 80,
                        CategoryId = 2,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "The Rise",
                        Author = "Kushi",
                        Description = "Book written by Kushi in 1950",
                        ISBN = "SWD000890L",
                        ListPrice = 199,
                        Price = 190,
                        Price50 = 185,
                        Price100 = 180,
                        CategoryId = 3,
                        ImageUrl = ""
                    }
                );
        }
    }
}

