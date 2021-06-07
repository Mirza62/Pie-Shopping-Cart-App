using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPie.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Pie> Pies { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Fruit Pies", Description = "All Fruity Pies" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Cheese Cakes", Description = "Cheese all the way" });
            modelBuilder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Seasonal Pies", Description = "Get in mood for a seasonal pie" });

            //seed Pies
            modelBuilder.Entity<Pie>().HasData(new Pie 
            {   PieId = 1,
                Name = "Strawberry Pie", 
                Price = 15.95M, 
                ShortDescription = "Lorem Ipsum", 
                LongDescription = "Lorem Ipsumsdfghjklkhgfdfghjklhgfghjklkjhgf", 
                CategoryId = 1, 
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                InStock = true,
                IsPieOfTheWeek = true,
                ImageThumbNailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
                PieId = 2,
                Name= "Cheese Cake", 
                Price = 18.95M, 
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem Ipsum", 
                CategoryId = 2,
                ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", 
                ImageThumbNailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                InStock = true,
                IsPieOfTheWeek = false,
                AllergyInformation = ""
            });

            modelBuilder.Entity<Pie>().HasData(new Pie
            {
              PieId = 3,
                Name= "Rhubarb Pie", 
                Price = 15.95M, 
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem Ipsum", 
                CategoryId = 3,
                ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", 
                ImageThumbNailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                IsPieOfTheWeek = true,
                InStock = true,
                AllergyInformation = ""
            });
        }
    }
}
