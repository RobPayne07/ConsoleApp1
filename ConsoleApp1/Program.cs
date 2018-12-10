using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valInt = false;
            Console.WriteLine("Header");

            do
            {
                if (!int.TryParse(Console.ReadLine(), out int k))
                {
                    valInt = false;
                }
                else
                {
                    Console.WriteLine("Well done, you're not a fuckup.");
                    valInt = true;
                }

            } while (!valInt);




            Console.ReadKey();
        }
    }
}
