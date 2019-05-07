using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MP_Couture
{
    class MP_Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = MP_App; Integrated Security = True; Connect Timeout = 30; Encrypt=False;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerID)
                       .HasName("PK_Customers");

                entity.Property(e => e.CustomerID)
                      .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailAddress)
                      .IsRequired()
                      .HasMaxLength(20);


            });
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey("PK_Carts");

                entity.Property(e => e.CartID)
                      .ValueGeneratedOnAdd();

                entity.HasOne(e => e.CartItem)
                      ;
                      
                
                        

            });
        }

    }
}
