using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class InstructionParser
    {
        private Position CurrentPosition;
        public static List<InstructionSet> ParseUserInstructions(string userInput)
        {
            var startPosition = new Position(2, 2, Direction.North);
            var instructions = userInput.Split(' ').Select(i =>
            {
                InstructionSet.CreateInstructionSet()
            });
            return [];
        }

        public InstructionParser(Position startPosition)
        {
            this.CurrentPosition = startPosition;
        }

        public (Instruction, Direction) ParseInstruction(string command, Position currentposition)
        {
            if (command == "") return (Instruction.E, Direction.None);

            return (default, default);

        }
    }
}
