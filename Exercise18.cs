using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Conditional_Statements
{
    class Exercise18
    {
        static void Main (string[] args)
        {
            int id, index;
            string name;
            double charge, disc = 0, total, net;     

            Console.Write("Input your ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input your name: ");
            name = Console.ReadLine();
            Console.Write("Input your index: ");
            index = Convert.ToInt32(Console.ReadLine());

            if (index < 199)
                charge = 1.2;
            else if (index >= 200 && index < 400)
                charge = 1.5;
            else if (index >= 400 && index < 600)
                charge = 1.8;
            else
                charge = 2.0;

            total = index * charge;

            if (total > 400)
                disc = total * 15 / 100;

            net = total + disc;

            if (net < 100)
                net = 100;
            
            Console.WriteLine("Customer ID No: {0}", id);
            Console.WriteLine("Customer Name: {0}", name);
            Console.WriteLine("Unit consumed:{0}", index);
            Console.WriteLine("Amount charges {0} per unit: {1}", charge, total);
            Console.WriteLine("Surchage amount: {0}", disc);
            Console.WriteLine("Net amount paid by the customer: {0}", net);
            Console.ReadLine();
        }
    }
}
