using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class User_interface
    {
        public static int UserInterface()
        {
            Console.Write("\nHello user, how many numbers need to be counted (2 or 3): ");
            int inputChoise;
            int.TryParse(Console.ReadLine(), out inputChoise);
            while (inputChoise < 1 || inputChoise > 3)
            {
                Console.WriteLine("Incorrect input, please input again");
                int.TryParse(Console.ReadLine(), out inputChoise);
            }
            return inputChoise;
        }
    }
}
