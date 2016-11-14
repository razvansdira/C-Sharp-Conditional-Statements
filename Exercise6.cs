using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise6
    {
        static void Main (String[] args)
        {
            int n;
            Console.Write("Input any number: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
                Console.WriteLine("The value of n = -1");
            else if (n == 0)
                Console.WriteLine("The value of n = 0.");
            else
                Console.WriteLine("The value of n = 1.");
            Console.ReadLine();
        }
    }
}
