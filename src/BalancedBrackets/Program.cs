using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceBrackets
{
    class Program
    {
        static void Main(string[] args)
        {

            BracketsTools tool = new BracketsTools();

            Console.WriteLine(new String('-', 50));

            Console.WriteLine(" {0,-30} {1} ", "Input", "Output");

            Console.WriteLine(new String('-', 50));

            foreach (var input in new string[]
            {
                "()[]{}(([])){[()][]}",
                "())[]{}",
                "[(])",
                "()[{{}}]([{}]{})"
            })
            {
                Console.WriteLine(" {0,-30} {1}", input, tool.GetBracketsState(input));

                Console.WriteLine(new String('-', 50));
            }
                    

            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();


        }
    }
}
