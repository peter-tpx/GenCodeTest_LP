using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzGeneratorTests
    {
        [Test]
        public void ShouldReturnNumber()
        {
            var input = 8;

            var output = FizzBuzzGenerator.GenerateElement(input);

            Assert.AreEqual("8", output.ToList()[0]);

        }


        [Test]
        public void ShouldReturnFizz()
        {
            var input = 9;

            var output = FizzBuzzGenerator.GenerateElement(input);

            Assert.AreEqual("Fizz", output.ToList()[0]);

        }

        [Test]
        public void ShouldReturnBuzz()
        {
            var input = 20;

            var output = FizzBuzzGenerator.GenerateElement(input);

            Assert.AreEqual("Buzz", output.ToList()[0]);

        }

        [Test]
        public void ShouldReturnFizzBuzz()
        {
            var input = 15;

            var output = FizzBuzzGenerator.GenerateElement(input);

            Assert.AreEqual("FizzBuzz", output.ToList()[0]);

        }

    }
}
