using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingSystem.Models
{
    public class StoreOrder
    {
        public int ID { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
