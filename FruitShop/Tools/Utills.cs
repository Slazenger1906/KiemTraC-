using System;
using FruitShop.Controller;
using FruitShop.Models;
using FruitShop.Tools;
using FruitShop.View;

public class Utills
{
    public static void CreateFruit(FruitCatalog fruitCatalog)
    {
        string name = Inputter.InputAString("Input a name");
        decimal price = Inputter.InputDecimal("Input a price");
        int quantity = Inputter.InputInt("Input a quantity");
        string origin = Inputter.InputAString("Input an origin");

        int id = fruitCatalog.GetID();

        Fruit fruit = new Fruit(id, name, price,quantity,origin);

        fruitCatalog.AddFruit(fruit);
    }

    public static void ShowReport(OrderManagement management)
    {
        foreach(var key in management)
        {
            string name = key.Key;
            List<Order> order = key.Value;
            var totalAmount = order.Sum(order => order.Price);
            Console.WriteLine("Custome Name: "+name);
            Menu.showProduct();
            foreach(var item in order)
            {
                int price = (int)(item.Price / item.Quantity);
                Console.WriteLine(item.Name +"    " +item.Quantity+"     " + price + "   " + item.Price);

            }
            Console.WriteLine("Total: " +totalAmount+"$");
            Console.WriteLine();
        }
       
    }
}
