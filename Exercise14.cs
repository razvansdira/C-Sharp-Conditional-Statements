using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise14
    {
        static void Main (string[] args)
        {
            int a, b, c;
            
            Console.WriteLine("Input the dimensions of triangle:");
            Console.Write("1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("3: ");
            c = Convert.ToInt32(Console.ReadLine());
           
            if (a == b && b == c)
                Console.WriteLine("The triangle is equilateral.");
            else if (a == b || a == c || b == c)
                Console.WriteLine("The triangle is isosceles.");
            else
                Console.WriteLine("The triangle is scalene.");
            Console.ReadLine();
        }
    }
}
