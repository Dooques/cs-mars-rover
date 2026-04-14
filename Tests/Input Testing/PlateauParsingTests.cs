using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Input;

namespace Tests.Input
{
    public class PlateauParsingTests
    {
        [TestCase("0 0", 0, 0)]
        [TestCase("1 1", 1, 1)]
        [TestCase("2 2", 2, 2)]
        [TestCase("6 6", 6, 6)]
        [TestCase("7 7", 7, 7)]
        [TestCase("hello", 0, 0)]
        [TestCase("", 0, 0)]
        public void ParsePlateau_ReturnPlateau_VariousInputs(string input, int expectedX, int expectedY)
        {
            var ip = new InputParser();
            var result = ip.ParsePlateauSize(input);

            Assert.That(result.Length, Is.EqualTo(expectedY));
            Assert.That(result.Width, Is.EqualTo(expectedX));
        }
    }
}
