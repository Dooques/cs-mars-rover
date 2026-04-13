using MarsRover;

namespace Tests
{
    public class InstructionParserTests
    {
        [Test(Description = "InstructionParser returns empty list when passed empty string")]
        public void InstructionParser_ReturnEmpty_EmptyString()
        {
            List<MarsRover.InstructionSet> expected = [];

            var instructionParser = new InstructionParser(new Position(2, 2, Direction.North));
            var result = instructionParser.ParseUserInstructions("");

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test(Description = "InstructionParser returns empty list when passed invalid string")]
        public void InstructionParser_ReturnListWithNoValues_InvalidSingleCharacterString()
        {
            var input = "X";
            List<InstructionSet> expected = [];
            
            var instructionParser = new InstructionParser(new Position(2, 2, Direction.North));
            var result = instructionParser.ParseUserInstructions(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test(Description = 
            "InstructionParser returns list with one when passed single character string")]
        public void InstructionParser_ReturnListWithOneValue_SingleCharacterString()
        {
            var input = "M";
            List<MarsRover.InstructionSet> expected = [new InstructionSet(Instruction.M, Direction.North)];

            var instructionParser = new InstructionParser(new Position(2, 2, Direction.North));
            var result = instructionParser.ParseUserInstructions(input);

            Assert.That(result, Is.EqualTo(expected));
        }

       
        //[Test(Description = "InstructionParser returns empty list when passed empty string")]
        public void InstructionParser_ReturnListWithValues_ValidString()
        {
            List<MarsRover.InstructionSet> expected = [];

            var instructionParser = new InstructionParser(new Position(2, 2, Direction.North));
            var result = instructionParser.ParseUserInstructions("");

            Assert.That(result, Is.EqualTo(expected));
        }

        //[Test(Description = "InstructionParser returns empty list when passed empty string")]
        public void InstructionParser_ReturnError_InvalidString()
        {
            List<MarsRover.InstructionSet> expected = [];

            var instructionParser = new InstructionParser(new Position(2, 2, Direction.North));
            var result = instructionParser.ParseUserInstructions("");

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}