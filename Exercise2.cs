using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise2
    {
        static void Main (String[] args)
        {
            int x, y;
            Console.WriteLine("Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            y = x % 2;

            if (y == 0)
                Console.WriteLine("{0} is even", x);
            else
                Console.WriteLine("{0} is odd.", x);

            Console.ReadLine();
        }
    }
}
