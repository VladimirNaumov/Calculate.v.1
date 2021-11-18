using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat_collection.Repeat();
            while (true)
            {
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "y":
                        {
                            Repeat_collection.Repeat();
                            Console.Write("Repeat, yes or no? Please input y/n: ");
                            break;
                        }
                    case "Y":
                        {
                            Repeat_collection.Repeat();
                            Console.WriteLine("Repeat, yes or no? Please input y/n:");
                            break;
                        }
                    case "n":
                        {
                            Console.WriteLine("GoodBye");
                            break;
                        }
                    case "N":
                        {
                            Console.WriteLine("GoodBye");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Incorrect input!\nPlease input y/n:");
                            break;
                        }
                }
            }
        }  // repair (added looping)

    }
}
