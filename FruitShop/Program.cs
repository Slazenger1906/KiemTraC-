using System.Threading.Channels;
using FruitShop.Controller;
using FruitShop.Models;
using FruitShop.Tools;
using FruitShop.View;

class Program
{
    public static void Main(string[] args)
    {
        bool flag = true;
        int choice = -1;
        FruitCatalog catalog = new FruitCatalog();
        catalog.Test();
        OrderManagement management = new OrderManagement();
      //  Console.WriteLine("FLAG");
       // catalog.ShowAllFruit();
        do
        {
            Menu.showMenu();
            choice = Inputter.InputInt("Input a choice");

            switch (choice)
            {
                case 1:
                    bool check = true;
                    do
                    {
                        Utills.CreateFruit(catalog);
                        Console.WriteLine("Do you want to continue(Y/N)?");
                        string ct = Console.ReadLine();
                        if (ct == "Y" || ct == "y")
                        {

                        }
                        else check = false;
                    } while(check);
                    
                    break;
                case 2:
                    Utills.ShowReport(management);
                    break;
                case 3:
                    Menu.showCatalog();
                    catalog.ShowAllFruit();
                    List<Order> list = new List<Order>();
                    bool kt = true;
                    do
                    {
                        string orderName = Inputter.InputAString("Select a name");
                        int quantity = Inputter.InputInt("Select a quantity");
                        Fruit candiate = catalog.SearchByName(orderName);
                        if (candiate == null)
                        {
                            Console.WriteLine("You choiced unfound fruit");
                            Console.WriteLine("Please input again");
                        }
                        else
                        {
                            Order order = new Order(orderName, quantity,candiate.Price*quantity);
                            list.Add(order);
                            Console.WriteLine("Do you want to continue(Y/N)?");
                            string ct = Console.ReadLine();
                            if (ct == "Y" || ct == "y")
                            {

                            }
                            else kt = false;
                        }

                    } while (kt);

                    string name = Inputter.InputAString("Your name is:");
                    management.AddOrderByName(name, list);
                    break;
                default:
                    flag = false;
                    Console.WriteLine("GoodBye!!");
                    break;

            }

        }
        while (flag); 


    }
}