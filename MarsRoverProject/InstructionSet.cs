using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class InstructionSet()
    {
        private static readonly List<Instruction> InstructionSetList = [];

        public static void CreateInstructionSet(Instruction instructionCommand)
        {
            if (instructionCommand is Instruction.E && direction is Direction.None)
            {
                return;
            }

            InstructionSetList.Add(instructionCommand));
        }
        public InstructionSet(Instruction instructionCommand, Direction direction) : this()
        {
            this.Command = instructionCommand;
        }

        public static List<InstructionSet> GetListOfInstructions()
        {
            return InstructionSetList;
        }

    }
}
