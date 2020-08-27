using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderingSystem.Models
{
    public enum OrderStatus
    {
        OnOrder, OutForDelivery, Ordered
    }
    public class Order
    {
        public int ID { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public OrderStatus? OrderStatus { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
