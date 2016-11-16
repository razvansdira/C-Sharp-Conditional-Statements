using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise13
    {
        static void Main(string[] args)
        {
            int t;
            Console.Write("Input the temperature: ");
            t = Convert.ToInt32(Console.ReadLine());

            if (t < 0)
                Console.WriteLine("Freezing weather");
            else if (t >= 0 && t < 10)
                Console.WriteLine("Very cold weather");
            else if (t >= 10 && t < 20)
                Console.WriteLine("Cold weather");
            else if (t >= 20 && t < 30)
                Console.WriteLine("Normal weather");
            else if (t >= 30 && t < 40)
                Console.WriteLine("Hot weaather");
            else
                Console.WriteLine("Very hot weather");
            Console.ReadLine();
        }
    }
}
