using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
    
        public static IEnumerable<string> GenerateElement(int specific = 0)
        {
            string result = string.Empty;

            Func<int, string> examine = (k) =>
            {
                if (k % 3 == 0)
                {

                    return (k % 5 == 0) ? "FizzBuzz" : "Fizz";

                }
                else if (k % 5 == 0)
                {
                    return "Buzz";
                }
                else
                {
                    return k.ToString();
                }
            };

            // -- specific input was introduced for testing purposes
            if (specific > 0 && specific <= 100)
            {
                yield return examine(specific);
            }
            else
            {
                for (var i = 1; i <= 100; i++)
                {
                    yield return examine(i);
                }
            }
        }
    }
}
