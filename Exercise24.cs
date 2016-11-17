using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise24
    {
        static void Main (string[] args)
        {
            int x, r, b, h, s;
            double area=0;

            Console.WriteLine("Input 1 for area of circle.");
            Console.WriteLine("Input 2 for area of triangle.");
            Console.WriteLine("Input 3 for area of square.");
            Console.Write("Input your choice: ");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.Write("Input the radius: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;
                case 2:
                    Console.Write("input the base: ");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("input the height: ");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = (b * h)/2;
                    break;
                case 3:
                    Console.Write("Input the side: ");
                    s = Convert.ToInt32(Console.ReadLine());
                    area = s * s;
                    break;
            }
            Console.WriteLine("The area is {0}.", area);
            Console.ReadLine();
        }
    }
}
