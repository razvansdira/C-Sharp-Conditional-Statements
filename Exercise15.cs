using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise15
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Input the angles of triangle:");
            Console.Write("1: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("3: ");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a!=0 && b!=0 && c!=0) && (a + b + c == 180))
                Console.WriteLine("The triangle is valid.");
            else
                Console.WriteLine("The triangle is invalid.");
            Console.ReadLine();
        }
    }
}
