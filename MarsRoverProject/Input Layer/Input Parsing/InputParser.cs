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
        public void ParsePlateauInput(string userInput)
        {
            var dm = new DataManager();

            int x = 0;
            int y = 0;
            foreach (var i in userInput.ToCharArray())
            {
                if (x == 0) 
                {
                    Console.WriteLine(i);
                    Int32.TryParse(i.ToString(), out x);
                    continue;
                } else if (y == 0)
                {
                    Console.WriteLine(i);
                    Int32.TryParse(i.ToString(), out y);
                    continue;
                } else if (x > 0 && y > 0)
                {
                    break;
                }
            }
            dm.CreatePlateau(x, y);
        }
    }
}
