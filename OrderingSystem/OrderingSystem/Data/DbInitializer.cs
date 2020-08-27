using OrderingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingSystem.Data
{
    public class DbInitializer
    {
        public static void Initialize(OrderingSystemContext context)
        {
            context.Database.EnsureCreated();
            if (context.Items.Any())
            {
                return;
            }

            var items = new Item[]
            {
                new Item{Price = 1.99, Active = true, OnHandBalance = 100, QuantityPerUnitOrdered = 10,},
                new Item{Price = 2.99, Active = true, OnHandBalance = 0, QuantityPerUnitOrdered = 11,},
                new Item{Price = 3.99, Active = false, OnHandBalance = 100, QuantityPerUnitOrdered = 8,},
                new Item{Price = 4.99, Active = true, OnHandBalance = 100, QuantityPerUnitOrdered = 10,},
                new Item{Price = 5.99, Active = true, OnHandBalance = 15, QuantityPerUnitOrdered = 10,},
                new Item{Price = 6.99, Active = false, OnHandBalance = 100, QuantityPerUnitOrdered = 12,},
            };

            context.Items.AddRange(items);
            context.SaveChanges();
        }
    }
}
