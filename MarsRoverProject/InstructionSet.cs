using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class InstructionSet()
    {
        private static readonly List<InstructionSet> InstructionSetList = [];
        Instruction InstructionCommand;
        Direction Direction;

        public static void CreateInstructionSet(Instruction instructionCommand, Direction direction)
        {
            if (instructionCommand is Instruction.E && direction is Direction.None)
            {
                return;
            }

            InstructionSetList.Add(new InstructionSet(instructionCommand, direction));
        }
        public InstructionSet(Instruction instructionCommand, Direction direction) : this()
        {
            this.InstructionCommand = instructionCommand;
            this.Direction = direction;
        }

        public static List<InstructionSet> GetListOfInstructions()
        {
            return InstructionSetList;
        }

    }
}
