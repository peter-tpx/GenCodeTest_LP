using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceBrackets
{
    public class BracketsTools
    {
        public const string BALANCED = "Balanced";
        public const string NOT_BALANCED = "Not Balanced";


        public string GetBracketsState(string input)
        {

            if (string.IsNullOrEmpty(input))
            {
                // -- assumption - empty string => no bracket => not balanced
                return NOT_BALANCED;
            }

            var matrix = new Dictionary<char, char>()
            {
                {'[', ']' },
                {'(', ')' },
                {'{', '}' }
            };

            var openedBraces = matrix.Keys.ToArray();
            var closedBraces = matrix.Values.ToArray();

            var stackBraces = new Stack<char>();


            var isBalanced = true;


            foreach (var c in input)
            {
                if (openedBraces.Any(b => b == c))
                {
                    stackBraces.Push(c);
                }

                else if (closedBraces.Any(b => b == c))
                {
                    if (stackBraces.Count == 0)
                    {
                        isBalanced = false;
                    }
                    else
                    {
                        char tmpChar;
                        if (!matrix.TryGetValue(stackBraces.Pop(), out tmpChar))
                        {
                            throw new Exception("Matching pair of brackets was not defined in the mattrix");
                        }

                        isBalanced = isBalanced && (tmpChar == c);
                    }
                }
                else
                {
                    isBalanced = false;
                }
            }

            stackBraces.Clear();

            return isBalanced ? BALANCED : NOT_BALANCED;
        }
    }
}
