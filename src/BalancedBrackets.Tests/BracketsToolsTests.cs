using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalanceBrackets;
using NUnit.Framework;

namespace BalancedBrackets.Tests
{
    [TestFixture]
    public class BracketsToolsTests
    {

        private static List<string> testList = new List<string>
        {            
            "()[]{}(([])){[()][]}|Balanced",
            "())[]{}|Not Balanced",
            "[(])|Not Balanced",
            "()[{{}}]([{}]{})|Balanced"
        };

        [Test]
        public void should_identify_string_as_balanced()
        {
            var input = "{}";

            var expected = "Balanced";

            BracketsTools tools = new  BracketsTools();

            Assert.AreEqual(tools.GetBracketsState(input), expected);
        }

        [Test]
        public void should_result_string_as_non_balanced()
        {
            var input = "{(})";

            var expected = "Not Balanced";

            BracketsTools tools = new BracketsTools();

            Assert.AreEqual(tools.GetBracketsState(input), expected);

        }

        [Test]
        [TestCaseSource("testList")]
        public void should_correctly_process_list(string inputElem)
        {

            var input = inputElem.Split('|')[0];
            var expected = inputElem.Split('|')[1];

            BracketsTools tools = new BracketsTools();

            Assert.AreEqual(tools.GetBracketsState(input), expected);
        }
    }
}
