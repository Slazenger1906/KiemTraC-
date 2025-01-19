using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitShop.Models;

namespace FruitShop.Controller
{
    public class OrderManagement : Dictionary<string, List<Order>>
    {
        public OrderManagement() { }
        public void AddOrderByName(string name, List<Order> list)
        {
            this.Add(name, list);
        }
    }
}
