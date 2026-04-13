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
            
            InstructionSet instruction = new();
            instruction.InstructionCommand = instructionCommand;
            instruction.Direction = direction;
            InstructionSetList.Add(instruction);
        }

        public static List<InstructionSet> GetListOfInstructions()
        {
            return InstructionSetList;
        }

    }
}
