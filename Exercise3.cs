using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise3
    {
        static void Main (string[] args)
        {
            int x;
            Console.Write("Input a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 0)
                Console.WriteLine("{0} is a negative nr.", x);
            else
                Console.WriteLine("{0} is a positive number.", x);
            Console.ReadLine();
        }
    }
}
