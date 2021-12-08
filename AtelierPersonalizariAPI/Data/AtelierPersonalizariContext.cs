using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AtelierPersonalizariAPI.Models;

namespace AtelierPersonalizariAPI.Data
{
    public class AtelierPersonalizariContext : DbContext
    {
        public AtelierPersonalizariContext(DbContextOptions<AtelierPersonalizariContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductTypeProvider> ProductTypeProviders { get; set; }
        public DbSet<PaymentProvider> PaymentProviders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Many to Many

            builder.Entity<OrderProduct>().HasKey(op => new { op.OrderId, op.ProductId });

            builder.Entity<OrderProduct>().HasOne<Order>(op => op.Order).WithMany(order => order.OrderProducts)
                                          .HasForeignKey(op => op.OrderId);

            builder.Entity<OrderProduct>().HasOne<Product>(op => op.Product).WithMany(product => product.OrderProducts)
                                          .HasForeignKey(op => op.ProductId);

            // One to Many

            builder.Entity<User>().HasMany(u => u.Orders).WithOne(o => o.User);
            builder.Entity<PaymentProvider>().HasMany(pp => pp.Orders).WithOne(o => o.PaymentProvider);
            builder.Entity<ProductType>().HasMany(pt => pt.Products).WithOne(p => p.ProductType);

            // One to One

            builder.Entity<ProductTypeProvider>().HasOne(ptp => ptp.ProductType).WithOne(pt => pt.ProductTypeProvider)
                                                 .HasForeignKey<ProductType>(pt => pt.ProductTypeProviderId);


            base.OnModelCreating(builder);
        }
    }
}
