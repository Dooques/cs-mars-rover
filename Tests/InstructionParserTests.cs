using MarsRover;

namespace Tests
{
    public class InstructionParserTests
    {
        [Test(Description = 
            "InstructionParser returns empty list when passed empty string")]
        public void InstructionParser_ReturnEmpty_EmptyString()
        {
            List<Instruction> expected = [];

            var instructionParser = new InputParser();
            var result = instructionParser.ParseUserInstructions("");

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test(Description = "InstructionParser returns empty list when passed invalid string")]
        public void InstructionParser_ReturnListWithNoValues_InvalidSingleCharacterString()
        {
            var input = "X";
            List<Instruction> expected = [];

            var instructionParser = new InputParser();
            var result = instructionParser.ParseUserInstructions(input);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test(Description =
            "InstructionParser returns list with one when passed single character string")]
        public void InstructionParser_ReturnListWithOneValue_SingleCharacterString()
        {
            var input = "M";
            List<Instruction> expected = new List<Instruction> { Instruction.M };

            var instructionParser = new InputParser();
            var result = instructionParser.ParseUserInstructions(input);

            Console.WriteLine("Result:");
            result.ForEach( i =>
            {
                Console.WriteLine($"{i}");
            });

            Console.WriteLine("Expected:");
            result.ForEach( i =>
            {
                Console.WriteLine($"{i}");
            });

            Assert.That(result, Is.EquivalentTo(expected));
        }

       
        [Test(Description = "InstructionParser list with values when passed valid string")]
        public void InstructionParser_ReturnListWithValues_ValidString()
        {
            List<Instruction> expected = [Instruction.M, Instruction.L, Instruction.R];

            var instructionParser = new InputParser();
            var result = instructionParser.ParseUserInstructions("MLR");

            result.ForEach(r =>
            {
                Console.WriteLine(r);
            });

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test(Description = "InstructionParser returns empty list when passed invalid string")]
        public void InstructionParser_ReturnEmpty_InvalidString()
        {
            List<Instruction> expected = [];

            var instructionParser = new InputParser();
            var result = instructionParser.ParseUserInstructions("YUIOP");

            Assert.That(result, Is.EqualTo(expected));
        }
        [Test(Description = "InstructionParser returns empty list when passed invalid string")]
        public void InstructionParser_ReturnEmptyList_SomeValidCharacters()
        {
            List<Instruction> expected = [];

            var instructionParser = new InputParser();
            var result = instructionParser.ParseUserInstructions("YUIOP");

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}