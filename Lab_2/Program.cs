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
            
            bool run = true;

            do
            {

                Console.Write("Please enter an integer between 1 and 100: ");
                int input = Convert.ToInt32(Console.ReadLine());

                Console.Write("\n");
                Console.Write("Output: ");

                if ((input % 2) != 0)
                {
                    Console.Write("Odd");

                }
                else if ((input % 2) == 0 && input >= 2 && input <= 25)
                {
                    Console.Write("Even and less than 25");
                }

                else if ((input % 2) == 0 && input >= 26 && input <= 60)
                {
                    Console.Write("Even");
                }

                else if ((input % 2) == 0 && input >= 60)
                {
                    Console.Write(input + " Even");
                }

                else if ((input % 2) != 0 && input >= 60)
                {
                    Console.Write(input + " Odd");
                }

                Console.WriteLine("\n");
                Console.WriteLine("\n");

                Console.Write("Do you want to continue? (y/n) ");
                string t = Console.ReadLine();
                if (t.ToLower() == "n")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Bye!");
                    Console.ReadKey();
                }
                    run = false;

                Console.WriteLine("\n");
            } while (run);


        }
    }
}
