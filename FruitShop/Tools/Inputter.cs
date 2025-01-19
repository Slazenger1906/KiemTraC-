using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop.Tools
{
    public class Inputter
    {
        public static string InputAString(string ms)
        {
            Console.WriteLine(ms);
            return Console.ReadLine();
        }
        public static int InputInt(string ms)
        {
            int ans = 0;
            bool flag = true;
            while (flag)
            {
                try
                {
                    ans = int.Parse(InputAString(ms));
                    if (ans <= 0) throw new Exception();
                    flag = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("You should input a  positive integer");

                }
            }
            return ans;
        }
        public static decimal InputDecimal(string ms)
        {
            decimal ans = 0;
            bool flag = true;
            while (flag)
            {
                try
                {
                    ans = Decimal.Parse(InputAString(ms));
                    if (ans <= 0) throw new Exception();
                    flag = false;

                }
                catch (Exception)
                {
                    Console.WriteLine("You should input a  positive number");

                }
            }
            return ans;
        }
    }
}
