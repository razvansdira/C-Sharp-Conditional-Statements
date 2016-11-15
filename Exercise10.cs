using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise10
    {
        static void Main (string[] args)
        {
            int x, y, z;
            Console.WriteLine("Input the marks obtained in: ");
            Console.Write("Pysics: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Chemistry: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Mathematics: ");
            z = Convert.ToInt32(Console.ReadLine());

            if (x >= 65 && y >= 55 && z >= 50 && x + y + z >= 180 || x + (x + y + z) >= 140)
                Console.WriteLine("The candidate is eligible for admission!");
            else
                Console.WriteLine("The candidate isn't eligible for admission.");
            Console.ReadLine();
        }
    }
}
