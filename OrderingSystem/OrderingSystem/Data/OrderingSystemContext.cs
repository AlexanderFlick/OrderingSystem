using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderingSystem.Models;

namespace OrderingSystem.Data
{
    public class OrderingSystemContext : DbContext
    {
        public OrderingSystemContext (DbContextOptions<OrderingSystemContext> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<StoreOrder> StoreOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<StoreOrder>().ToTable("StoreOrder");
        }
    }
}
