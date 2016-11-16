using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise12
    {
        static void Main (string[] args)
        {
            int x, p, c, a, t, proc;
            string n, d;

            Console.Write("Input a roll number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a name: ");
            n = Convert.ToString(Console.ReadLine());
            Console.Write("Input the marks of phisics: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks of chemistry: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks of computer application: ");
            a = Convert.ToInt32(Console.ReadLine());

            t = a + c + p;
            proc = (a + c + p) / 3;
            if (proc >= 75)
                d = "First";
            else if (proc < 75 && proc >= 50)
                d = "Second";
            else if (proc < 50 && proc >= 25)
                d = "Third";
            else
                d = "Fourth";

            Console.WriteLine("Roll No: {0}", x);
            Console.WriteLine("Name of Student: {0}", n);
            Console.WriteLine("Marks in physics: {0}", p);
            Console.WriteLine("Marks in Chemistry: {0}", c);
            Console.WriteLine("MArks in Computer Application: {0}", a);
            Console.WriteLine("Total Marks: {0}", t);
            Console.WriteLine("Percentage: {0}", proc);
            Console.WriteLine("Division: {0}", d); ;

            Console.ReadLine();
        }
    }
}
