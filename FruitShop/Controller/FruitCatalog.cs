using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FruitShop.Models;

namespace FruitShop.Controller
{
    public class FruitCatalog : List<Fruit>
    {
        public FruitCatalog() { }
        public void AddFruit(Fruit fruit)
        {
            this.Add(fruit);
        }

        public int GetID() {

            return this.Count() + 1;
        }
        public string ShowInfoOfFruit(Fruit fruit)
        {
            return "     "+fruit.ID + "          " +fruit.Name+"       " +fruit.Origin +"        " + fruit.Price + "$";
        }
        public void ShowAllFruit()
        {
            
            foreach (Fruit fruit in this)
            {
                Console.WriteLine(ShowInfoOfFruit(fruit));
            }
        }

        public void Test()
        {
            this.Add(new Fruit(1, "Coconut", 10, 2,"VietNam"));
            this.Add(new Fruit(2, "Apple", 2, 3,"USA"));
            this.Add(new Fruit(3, "Mango", 1, 4,"VietNam"));
        }

        public Fruit SearchByName(string name)
        {
            Fruit fruit = null;
            foreach (Fruit fruit1 in this) {
                if (fruit1.Name.ToLower().Equals(name.ToLower()))
                {
                    fruit= fruit1; break;
                }
            }

            return fruit;
        }
    }
}
