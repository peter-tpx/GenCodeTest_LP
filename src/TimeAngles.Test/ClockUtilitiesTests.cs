using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TimeAngles.Test
{
    [TestFixture]
    public class ClockUtilitiesTests
    {


        [Test]
        [TestCase("1:30", 45)]
        [TestCase("3:55", 117.5)]
        public void Should_return_corrent_left_hand_angle(string time, double expected)
        {
            DateTime inputDT;

            var x = DateTime.TryParse(time, out inputDT);

            var output = ClockUtilities.GetShortHandAngle(inputDT);

            Assert.AreEqual(expected, output);
            
        }

        [Test]
        [TestCase("1:30", 180)]
        [TestCase("3:55", 330)]
        public void Should_return_corrent_right_hand_angle(string time, double expected)
        {
            DateTime inputDT;

            var x = DateTime.TryParse(time, out inputDT);

            var output = ClockUtilities.GetLongHandAngle(inputDT);

            Assert.AreEqual(expected, output);

        }


        [Test]
        [TestCase("1:30", 135)]
        [TestCase("3:55", 147.5)]
        public void Should_return_corrent_result_angle(string time, double expected)
        {
            DateTime inputDT;

            var x = DateTime.TryParse(time, out inputDT);

            var output = ClockUtilities.GetHandAngle(inputDT);

            Assert.AreEqual(expected, output);

        }
    }
}
