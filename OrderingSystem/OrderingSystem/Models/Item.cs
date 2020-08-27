using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingSystem.Models
{
    public class Item
    {
        public int ID { get; set; }
        public double Price { get; set; }
        public int OnHandBalance { get; set; }
        public int QuantityPerUnitOrdered { get; set; }
        public bool Active { get; set; }
    }
}
