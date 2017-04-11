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


            if ((input % 2) != 0)
            {
                Console.WriteLine("Odd");

            }

            else if((input % 2) == 0 && input >=2 && input <= 25)
            {
                Console.WriteLine("Even and less than 25");
            }
            
            else if((input % 2) == 0 && input >= 26 && input <= 60)
            {
                Console.WriteLine("Even");
            }

            else if ((input % 2) == 0 && input >= 60)
            {
                Console.WriteLine(input + "Even");
            }

            else if ((input % 2) != 0 && input >= 60)
            {
                Console.WriteLine(input + "Odd");
            }



            Console.ReadKey();
        }
    }
}
