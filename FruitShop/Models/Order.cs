using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class Order
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Order(string name, int quantity, decimal price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }
    }
}
