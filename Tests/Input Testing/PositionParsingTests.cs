using MarsRover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Model;
using MarsRover.Input;

namespace Tests.Input
{
    internal class PositionParsingTests
    {
        [TestCase("1 1 N", 1, 1, Direction.North)]
        [TestCase("2 2 S", 2, 2, Direction.South)]
        [TestCase("1 4 E", 1, 4, Direction.East)]
        [TestCase("6 2 W ", 6, 2, Direction.West)]
        [TestCase("", 0, 0, Direction.None)]
        [TestCase("hello", 0, 0, Direction.None)]
        [TestCase("123456789", 0, 0, Direction.None)]
        public void ParsingPosition_ReturnPosition_VariousValues(string input, int expectedX, int expectedY, Direction expectedDirection)
        {
            var ip = new InputParser();
            var testPosition = ip.ParsePositionInput(input);

            Assert.That(testPosition.X, Is.EqualTo(expectedX));
            Assert.That(testPosition.Y, Is.EqualTo(expectedY));
            Assert.That(testPosition.Direction, Is.EqualTo(expectedDirection));
        }
    }
}
