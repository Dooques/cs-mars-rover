using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
                if (!Enum.IsDefined(typeof(Instruction), i)) return i;
                /* if instruction is not an instruction, return without parsing */

                var parseResult = ParseInstruction(i, CurrentPosition);
                InstructionSet.CreateInstructionSet(parseResult.Item1, parseResult.Item2);
                return i;
            }).ToList();
            return InstructionSet.GetListOfInstructions();
        }

        public InstructionParser(Position startPosition)
        {
            this.CurrentPosition = startPosition;
        }

        public (Instruction, Direction) ParseInstruction(string command, Position currentposition)
        {
            if (command == "") return (default, default);

            Direction[] directions = [Direction.North, Direction.East, Direction.South, Direction.West];

            var instruction = command.ToUpper() switch
            {
                "R" => Instruction.R,
                "L" => Instruction.L,
                "M" => Instruction.M,
                _ => Instruction.E
            };

            var newDirection = instruction switch
            {
                Instruction.L => directions[Array.IndexOf(directions, currentposition.Direction) - 1 + 4 % 4],
                Instruction.R => directions[Array.IndexOf(directions, currentposition.Direction) + 1 - 4 % 4],
                _ => currentposition.Direction
            };

            return (instruction, newDirection);
        }
    }
}
