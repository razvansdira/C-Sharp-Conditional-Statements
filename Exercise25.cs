using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise25
    {
        static void Main(string[] args)
        {
            int x, y, op;

            Console.Write("Input fisrt number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input second number ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input 1 for addition.");
            Console.WriteLine("Input 2 for substraction.");
            Console.WriteLine("Input 3 for multiplication");
            Console.WriteLine("Input 4 for division.");
            Console.WriteLine("Input 5 for exit.");

            Console.Write("Input your choice: ");
            op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("The addition of {0} and {1} is = {2}.", x,y, x+y);
                    break;
                case 2:
                    Console.Write("The substraction of {0} and {1} is = {2}", x, y, x - y);
                    break;
                case 3:
                    Console.Write("The multiplication of {0} and {1} is : {2}.", x, y, x * y);
                    break;
                case 4:
                    Console.Write("The division of {0} and {1} is = {2}.", x, y, x / y);
                    break;
                case 5:
                    Console.Write("Exit...");
                    break;
                default:
                    Console.Write("Input other number !!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
