using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz Generator Output:");

            int counter = 1;
            foreach (var o in FizzBuzzGenerator.GenerateElement())
            {
                Console.WriteLine("{0,-3}: {1}", counter++, o);               
            }

            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();

        }
    }
}
