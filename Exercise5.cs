using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise5
    {
        static void Main (String[] args)
        {
            int x;
            Console.Write("Input your age: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x >= 18)
                Console.WriteLine("Congratulation !!!! ");
            else
                Console.WriteLine("Sorry...");
            Console.ReadLine();
        }
    }
}
