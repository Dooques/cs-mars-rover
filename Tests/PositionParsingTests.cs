using MarsRover;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    internal class PositionParsingTests
    {
        [TestCase("1 1 N", 1, 1, Direction.North)]
        public void ParsingPosition_ReturnPosition_VariousValues(string input, int expectedX, int expectedY, Direction expectedDirection)
        {
            var ip = new InputParser();
            var testPosition = ip.ParsePositionInput(input);
        }
    }
}
