using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Input;

namespace MarsRover.Model
{
    public class DataManager()
    {
        private List<Instruction> InstructionList = [];
        private PlateauSize? PlateauSizeRecord = null;
        private Position? RoverPosition = null;

        public void CreateRover(int x, int y, Direction direction)
        {
            RoverPosition = new Position(x, y, direction);
        }

        public Position GetRoverPosition()
        {
            if (RoverPosition != null)
            {
                return RoverPosition;
            }
            return new Position(0, 0, Direction.None);
        }

        public void CreatePlateau(int x, int y)
        {
            PlateauSizeRecord = new PlateauSize(x, y);
        }

        public PlateauSize GetPlateau()
        {
            if (PlateauSizeRecord != null)
            {
                return PlateauSizeRecord;
            }
            else return new PlateauSize(0, 0);
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
