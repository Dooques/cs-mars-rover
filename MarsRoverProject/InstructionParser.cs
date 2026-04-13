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

        public List<InstructionSet> ParseUserInstructions(string userInput)
        {
            var instructions = userInput.Split(' ').Select(i =>
            {
                var parseResult = ParseInstruction(i, CurrentPosition);
                Console.WriteLine(parseResult);
                InstructionSet.CreateInstructionSet(parseResult.Item1, parseResult.Item2);
                return i;
            }).ToList();
            return [];
        }

        public InstructionParser(Position startPosition)
        {
            this.CurrentPosition = startPosition;
        }

        public (Instruction, Direction) ParseInstruction(string command, Position currentposition)
        {
            if (command == "") return (default, default);

            return (default, default);
        }
    }
}
