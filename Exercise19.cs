using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise19
    {
        static void Main(string[] args)
        {
            char x;

            Console.Write("Input a letter of grade: ");
            x = Convert.ToChar(Console.ReadLine());

            if (x == 'a')
                Console.WriteLine("Average");
            else if (x == 'e')
                Console.WriteLine("Excellent");
            else if (x == 'f')
                Console.WriteLine("Fail");
            else if (x == 'g')
                Console.WriteLine("Good");
            else if (x == 'v')
                Console.WriteLine("Very good");
            else
                Console.WriteLine("Not grade.");
            
            Console.ReadLine();
        }
    }
}
