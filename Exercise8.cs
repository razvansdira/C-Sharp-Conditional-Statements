using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise8
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input third number: ");
            z = Convert.ToInt32(Console.ReadLine());

            if ((x > y) && (x > z))
                Console.WriteLine("The first number is the greatest among three.");
            else if ((y > x) && (y > z))
                Console.WriteLine("The second number is the greatest among three");
            else if ((z > x) && (z > y))
                Console.WriteLine("The third number is the greatest among three.");
            else
                Console.WriteLine("Equal");
            Console.ReadLine();
        }
    }
}
