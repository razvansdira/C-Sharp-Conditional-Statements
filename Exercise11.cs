using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise11
    {
        static void Main (string[] args)
        {
            int a, b, c;
            double d, x, x1, x2;

            Console.WriteLine("Input the value of: ");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine("Root = {0} ", x);

            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.Write("Root 1 = {0}\n", x1);
                Console.Write("Root 2 = {0}", x2);
            }
            else
                Console.WriteLine("Root are imeainary; \n No Solution.");

            Console.ReadLine();
        }
    }
}
