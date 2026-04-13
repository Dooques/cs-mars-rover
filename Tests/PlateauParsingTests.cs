using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;

namespace Tests
{
    public class PlateauParsingTests
    {
        [TestCase("1, 1", 0, 0)]
        [TestCase("2, 2", 1, 1)]
        [TestCase("6, 6", 5, 5)]
        [TestCase("7, 7", 0, 0)]
        public void ParsePlateau_ReturnPlateau_VariousInputs(string input, int expectedX, int expectedY)
        {
            var ip = new InputParser();
            var result = ip.ParsePlateauInput(input);

            Assert.That(result.Length, Is.EqualTo(expectedY));
            Assert.That(result.Width, Is.EqualTo(expectedX));

        }

    }
}
