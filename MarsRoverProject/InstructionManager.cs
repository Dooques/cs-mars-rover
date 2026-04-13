using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class InstructionManager()
    {
        private List<Instruction> InstructionList = [];

        public void AddInstruction(Instruction instructionCommand)
        {
            if (instructionCommand is Instruction.E)
            {
                return;
            }

            InstructionList.Add(instructionCommand);
        }

        public List<Instruction> GetListOfInstructions()
        {
            return InstructionList;
        }
        
        public void ClearList()
        {
            InstructionList = new List<Instruction>();
        }
    }
}
