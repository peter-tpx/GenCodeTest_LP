using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeAngles
{
    class Program
    {
        static void Main(string[] args)
        {

            ClockUtilities tool = new ClockUtilities();

            Console.WriteLine(new String('-', 50));

            Console.WriteLine("Clock angle calculator");

            Console.WriteLine(" - Enter time in format hh:mm (12h) or press enter to exit... ");

            Console.WriteLine(new String('-', 50));


            string input;

            input = Console.ReadLine();

            input = string.IsNullOrEmpty(input) ? DateTime.Now.ToString("hh:mm") : input;

            DateTime inputDT;

            if (!DateTime.TryParse(input, out inputDT))
            {
                Console.WriteLine("Error: Invalid input time!");
            }


            var output = ClockUtilities.GetHandAngle(inputDT);

            Console.WriteLine($"The angle for time {input} is {output} degrees");

            Console.WriteLine(new String('-', 50));


            Console.WriteLine("Press any key to exit...");

            Console.ReadKey();

        }
    }
}
