using MarsRover.Input_Layer;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class InputParser
    {
        public List<Instruction> ParseRoverInstructions(string userInput)
        {
            var im = new DataManager();
            foreach (var i in userInput.ToCharArray().ToList())
            {
                var instruction = i.ToString().ToUpper() switch
                {
                    "R" => Instruction.R,
                    "L" => Instruction.L,
                    "M" => Instruction.M,
                    _ => Instruction.E
                };

                if (instruction is Instruction.E) {
                    Console.WriteLine("Some of these characters are invalid, Please enter a valid string");
                    break;
                }

                im.AddInstruction(instruction);
            };
            return im.GetListOfInstructions();
        }
        public PlateauSize ParsePlateauInput(string userInput)
        {
            return new PlateauSize(0, 0);
        }
    }
}
