using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise9
    {
        static void Main (string[] args)
        {
            int x, y;
            Console.Write("Input the x coordinate:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the y coordinate: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the first quadrant.", x, y);
            else if (x < 0 && y > 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the second quadrant.", x, y);
            else if (x < 0 && y < 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the third quadrant.", x, y);
            else if (x > 0 && y < 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in the fourth quadrant.", x, y);
            else
                Console.WriteLine("Origin");

            Console.ReadLine();
        }
    }
}
