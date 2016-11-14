using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise4
    {
        static void Main(string[] args)
        {
            int x;
            Console.Write("Enter an year: ");
            x = Convert.ToInt32(Console.ReadLine());

            if ((x % 400) == 0)
                Console.WriteLine("{0} is a leap year...", x);
            else if ((x % 100) == 0)
                Console.WriteLine("{0} isn't a leap year..", x);
            else if ((x % 4) == 0)
                Console.WriteLine("{0} is a leap year.",x);
            else
                Console.WriteLine("{0} isn't a leap year", x);
            Console.ReadLine();
        }
    }
}
