namespace Tests
{
    public class InstructionSetTests
    {
        [Test(Description = "Should return empty instruction set list when no items created.")]
        public void InstructionSet_EmptyList_PassedEmptyString()
        {
            var expected = new List<MarsRover.InstructionSet>();

            MarsRover.InstructionSet.CreateInstructionSet(MarsRover.Instruction.E, MarsRover.Direction.None);
            List<MarsRover.InstructionSet> result = MarsRover.InstructionSet.GetListOfInstructions();
            result.ForEach(Console.WriteLine);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test(Description = "Should return empty instruction set list when passed no values.")]
        public void InstructionSet_EmptyList_PassedNoValues()
        {
            var expected = new List<MarsRover.InstructionSet>();

            List<MarsRover.InstructionSet> result = MarsRover.InstructionSet.GetListOfInstructions();
            result.ForEach(Console.WriteLine);

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test(Description = "Should return instruction set list when passed a value.")]
        public void InstructionSet_ListWithValue_PassedOneInstructionSet()
        {
            var expected = new List<MarsRover.InstructionSet>();

            List<MarsRover.InstructionSet> result = MarsRover.InstructionSet.GetListOfInstructions();
            result.ForEach(Console.WriteLine);

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
