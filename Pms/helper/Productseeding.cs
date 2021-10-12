using Microsoft.EntityFrameworkCore;
using Pms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pms.helper
{
    public static class Productseeding
    {
        public static void Seed(this ModelBuilder modelBuilder ) {

            modelBuilder.Entity<Product>().HasData(

               new Product { Id=1,Name = "Iphone1", Price = 1000, Quantity = 10, ImageUrl = "~/Image/1.jpg" },
                              new Product { Id = 2,  Name = "Iphone2", Price = 100, Quantity = 10, ImageUrl = "~/Image/1.jpg" },
                              new Product { Id = 3, Name = "Iphone3", Price = 1000, Quantity = 10, ImageUrl = "~/Image/1.jpg" },
                                 new Product { Id = 4, Name = "Iphone4", Price = 1000, Quantity = 10, ImageUrl = "~/Image/1.jpg" },
                              new Product { Id = 5, Name = "Iphone5", Price = 100, Quantity = 10, ImageUrl = "~/Image/1.jpg" },
                              new Product { Id = 6, Name = "Iphone6", Price = 1000, Quantity = 10, ImageUrl = "~/Image/1.jpg" },
                                 new Product { Id = 7, Name = "Iphone7", Price = 1000, Quantity = 10, ImageUrl = "~/Image/1.jpg" },
                              new Product { Id = 8, Name = "Iphone8", Price = 100, Quantity = 10, ImageUrl = "~/Image/1.jpg"},
  new Product { Id = 9, Name = "Iphone00", Price = 1000, Quantity = 10, ImageUrl = "~/Image/1.jpg" },
                               new Product { Id = 10, Name = "Iphone10", Price = 1000, Quantity = 10, ImageUrl = "~/Image/1.jpg" }
            );
        }
    }
}
