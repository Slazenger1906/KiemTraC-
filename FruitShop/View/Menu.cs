using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitShop.Models;
using System.Xml.Linq;

namespace FruitShop.View
{
    public class Menu
    {
        public static void showMenu()
        {
            string menu = "FRUIT SHOP SYSTEM\r\n" +
                "1.Create Fruit\r\n" +
                "2.View orders\r\n" +
                "3.Shopping(for buyer)\r\n" +
                "4.Exit";
            Console.WriteLine(menu);
        }
        public static void showCatalog()
        {
            Console.WriteLine("List of Fruit");
            Console.WriteLine("| ++Item++ | ++Fruit Name++ | ++Origin++ | ++Price++ | ");

        }

        public static void showProduct()
        {
            Console.WriteLine("Product|Quantity|Price|Amount");

        }



    }
}
