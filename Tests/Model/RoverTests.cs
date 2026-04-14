using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Model;
using System.Reflection.Metadata;

namespace Tests.Model
{
    internal class RoverTests
    {
        [Test]
        public void Rover_ReturnRover_ValidInput()
        {
            string nameInput = "John";
            Position inputPosition = new MarsRover.Model.Position(2, 2, Direction.North);
            string expectedName = "John";
            Position expectedPosition = inputPosition;

            var testRover = new Rover(nameInput, inputPosition);

            Assert.That(testRover.Name, Is.EqualTo(expectedName));
            Assert.That(testRover.CurrentPosition, Is.EqualTo(expectedPosition));
        }

        [Test]
        public void Rover_ThrowsFormatException_InvalidName()
        {
            string nameInput = "";
            Position inputPosition = new Position(2, 2, Direction.North);

            Assert.Throws<FormatException>(() => new Rover(nameInput, inputPosition));
        }

        [Test]
        public void Rover_ThrowsFormatException_InvalidPositionDirection()
        {
            string nameInput = "";
            Position inputPosition = new Position(2, 2, Direction.None);

            Assert.Throws<FormatException>(() => new Rover(nameInput, inputPosition));
        }

        [Test]
        public void Rover_ThrowsFormatException_InvalidPositionNegativeIntegers()
        {
            string nameInput = "";
            Position inputPosition = new Position(-2, -2, Direction.North);

            Assert.Throws<FormatException>(() => new Rover(nameInput, inputPosition));
        }
    }
}
