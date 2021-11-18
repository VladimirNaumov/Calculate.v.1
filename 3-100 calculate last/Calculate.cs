using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class Calculate
    {
        public static void Calculating(int[] items)
        {

            Console.Write("_____________\n\n Processing: ");
            if (items.Length == 3)
            {
                if (items[0] == 1)
                {
                    Console.WriteLine("Sum= " + (items[1] + items[2]));
                }
                if (items[0] == 2)
                {
                    Console.WriteLine("Subtraction= " + (items[1] - items[2]));
                }
                if (items[0] == 3)
                {
                    Console.WriteLine("Increase= " + (items[1] * items[2]));
                }
                if (items[0] == 4)
                {
                    double div = (double)items[1] / (double)items[2];
                    Console.WriteLine("Division = " + Math.Round(div, 1));
                }
            }

            if (items.Length == 4)
            {
                if (items[0] == 1)
                {
                    Console.WriteLine("Sum= " + (items[1] + items[2] + items[3]));
                }
                if (items[0] == 2)
                {
                    Console.WriteLine("Subtraction= " + (items[1] - items[2] - items[3]));
                }
                if (items[0] == 3)
                {
                    Console.WriteLine("Increase= " + (items[1] * items[2] * items[3]));
                }
                if (items[0] == 4)
                {
                    double div = (double)items[1] / (double)items[2] / (double)items[3];
                    Console.WriteLine("Division = " + Math.Round(div, 1));
                }
                Console.Write("_____________\n\n Processing: ");
            }
        }  //repair (conversion )
    }
}
