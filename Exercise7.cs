using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise7
    {
        static void Main (String[] args)
        {
            int x;
            Console.Write("Input your height: ");
            x = Convert.ToInt32(Console.ReadLine());

            if (x < 150)
                Console.WriteLine("The person is dwarf");
            else if ((x >= 150) && (x <= 170))
                Console.WriteLine("The person is normal");
            else
                Console.WriteLine("The person is tall.");
            Console.ReadLine();
        }
    }
}
