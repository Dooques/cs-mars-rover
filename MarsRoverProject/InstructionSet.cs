using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    internal record InstructionSet()
    {
        private static readonly List<InstructionSet> InstructionSetList = [];
        Instruction InstructionCommand;
        Direction Direction;

        public InstructionSet(Instruction instructionCommand, Direction direction) : this()
        {
            this.InstructionCommand = instructionCommand;
            this.Direction = direction;
            InstructionSetList.Add(this);
        }

        public List<InstructionSet> GetListOfInstructions()
        {
            return InstructionSetList;
        }

    }
}
