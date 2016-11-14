using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise1
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x == y)
                Console.WriteLine("{0} and {1} are equal.", x, y);
            else
                Console.WriteLine("{0} and {1} aren't equal.", x, y);

            Console.ReadLine();
        }
    }
}
