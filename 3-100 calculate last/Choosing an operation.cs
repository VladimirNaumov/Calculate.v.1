using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_100_calculate_last
{
    class Choosing_an_operation
    {
        public static int ChoosingAnOperation()
        {
            Console.WriteLine("Which operation need?\n1: +\n2: -\n3: *\n4: /");
            int inputOperation;
            int.TryParse(Console.ReadLine(), out inputOperation);
            while (inputOperation < 1 || inputOperation > 4)
            {
                Console.WriteLine("Incorrect input, please input again");
                int.TryParse(Console.ReadLine(), out inputOperation);
            }
            return inputOperation;
        }
    }
}
