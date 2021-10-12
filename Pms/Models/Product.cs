using Microsoft.EntityFrameworkCore;
using Pms.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pms.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }
        public int Price { get; set; }

        public int Quantity { get; set; }
        public string ImageUrl { get; set; }


    }


    public class Producttree
    {
        public IEnumerable<Product> Products { get; set; }
    }

    public class TestDbContex : DbContext
    {
        public TestDbContex(DbContextOptions<TestDbContex> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
           protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
          
        }
    }
}
