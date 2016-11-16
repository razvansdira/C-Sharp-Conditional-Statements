using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise17
    {
        static void Main (string[] args)
        {
            int b, s, l, p;

            Console.Write("Input a buy price: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a sale price: ");
            s = Convert.ToInt32(Console.ReadLine());

            p = s - b;
            l = b - s;
            if (s > b)
                Console.WriteLine("You can booked your profit amount : {0}", p);
            else if (s == b)
                Console.WriteLine("You loss the time.");
            else
                Console.WriteLine("You can booked your loss amount : {0}", l);
            Console.ReadLine();
        }
    }
}
