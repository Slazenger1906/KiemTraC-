using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class Fruit
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Origin { get; set; }

        public Fruit(int iD, string name, decimal price, int quantity, string origin)
        {
            ID = iD;
            Name = name;
            Price = price;
            Quantity = quantity;
            Origin = origin;
        }
    }
}
