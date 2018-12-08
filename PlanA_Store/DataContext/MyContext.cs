using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanA_Store.DataContext
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
         : base(options)
        {
        }

        public DbSet<Models.Admin> Admins { get; set; }
        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.OrderDetails> OrderDetails { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.OrderDetails>()
                .HasKey(en => new { en.OrderID, en.ProductID });

            modelBuilder.Entity<Models.OrderDetails>()
                .HasOne(en => en._Order)
                .WithMany(b => b.ProductsList)
                .HasForeignKey(en => en.OrderID);

            modelBuilder.Entity<Models.OrderDetails>()
                .HasOne(co => co._Product)
                .WithMany(c => c.OrdersList)
                .HasForeignKey(en => en.ProductID);


        }




    }

}
