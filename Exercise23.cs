using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise23
    {
        static void Main(string[] args)
        {
            int luna;
            Console.Write("Input a number 1-12: ");
            luna = Convert.ToInt32(Console.ReadLine());

            switch (luna)
            {
                case 1:
                    Console.WriteLine("Month  have 31 days.");
                    break;
                case 2:
                    Console.WriteLine("Month  have 28 days.");
                    break;
                case 3:
                    Console.WriteLine("Month  have 31 days.");
                    break;
                case 4:
                    Console.WriteLine("Month  have 30 days.");
                    break;
                case 5:
                    Console.WriteLine("Month  have 31 days.");
                    break;
                case 6:
                    Console.WriteLine("Month  have 30 days.");
                    break;
                case 7:
                    Console.WriteLine("Month  have 31 days.");
                    break;
                case 8:
                    Console.WriteLine("Month  have 31 days.");
                    break;
                case 9:
                    Console.WriteLine("Month  have 30 days.");
                    break;
                case 10:
                    Console.WriteLine("Month  have 31 days.");
                    break;
                case 11:
                    Console.WriteLine("Month  have 30 days.");
                    break;
                case 12:
                    Console.WriteLine("Month  have 31 days.");
                    break;
                default:
                    Console.WriteLine("Other number.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
