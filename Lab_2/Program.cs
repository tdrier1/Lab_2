using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Automate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PLease enter an integer between 1 and 100");
            int input = Convert.ToInt32(Console.ReadLine());

            int f = (input % 2);

            if ((input % 2) != 0)
            {
                Console.WriteLine("Odd");

            }
            Console.ReadKey();
        }
    }
}
