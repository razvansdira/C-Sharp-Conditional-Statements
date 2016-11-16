using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise16
    {
        static void Main(string[] args)
        {
            char abc;
            Console.Write("Input a leter: ");
            abc = Convert.ToChar(Console.ReadLine());
            if (abc == 'a' || abc == 'e' || abc == 'i' || abc == 'o' || abc == 'u')
                Console.WriteLine("It's vowel.");
            else
                Console.WriteLine("It's a consonant.");
            Console.ReadLine();
        }
    }
}
