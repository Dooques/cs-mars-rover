namespace Tests
{
    public class InstructionParserTests
    {
        [Test(Description = "InstructionParser returns empty list when passed empty string")]
        public void InstructionParser_ReturnEmpty_EmptyString()
        {
            List<MarsRover.InstructionSet> expected = [];
            var result = MarsRover.InstructionParser.ParseUserInstructions("");

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}