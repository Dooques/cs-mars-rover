using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class DataManager()
    {
        private List<Instruction> InstructionList = [];
        private PlateauSize? PlateauSizeRecord = null;

        public void CreatePlateau(int x, int y)
        {
            PlateauSizeRecord = new PlateauSize(x - 1, y - 1);
        }

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
