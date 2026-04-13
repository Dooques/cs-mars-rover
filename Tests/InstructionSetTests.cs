using MarsRover;

namespace Tests
{
    public class InstructionSetTests
    {
        [Test(Description = "Should return empty instruction set list when no items created.")]
        public void InstructionSet_EmptyList_PassedEmptyString()
        {
            var im = new InstructionManager();
            List<Instruction> result = im.GetListOfInstructions();

            Assert.That(result, Is.Empty);
        }

        [Test(Description = "Should return empty instruction set list when passed invalid instruction.")]
        public void InstructionSet_EmptyList_PassedNoValues()
        {
            List<Instruction> expected = new();

            var im = new InstructionManager();
            im.AddInstruction(Instruction.E);

            List<Instruction> result = im.GetListOfInstructions();

            Assert.That(result, Is.EquivalentTo(expected));
        }

        [Test(Description = "Should return instruction set list when passed a value.")]
        public void InstructionSet_ListWithValue_PassedOneInstructionSet()
        {
            List<Instruction> expected = new() { Instruction.M };

            var im = new InstructionManager();
            im.AddInstruction(Instruction.M);

            List<Instruction> result = im.GetListOfInstructions();

            Assert.That(result, Is.EquivalentTo(expected));
        }
    }
}
