using MarsRover.Input;

namespace MarsRover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var plateauSizeTest = "5 5";
            var roverPositionTest = "1 2 N";
            var instructionTest = "LMLMLMLMM";

            var ip = new InputParser();
            var dm = new DataManager();

            var plateau = ip.ParsePlateauSize(plateauSizeTest);
            var roverPosition = ip.ParsePosition(roverPositionTest);
            var instruction = ip.ParseRoverInstructions(instructionTest);

            Console.WriteLine($"Plateau Size: {plateau.Width}, {plateau.Length}");
            Console.WriteLine($"Rover Position: {roverPosition.X}, {roverPosition.Y}, {roverPosition.Direction}");
            Console.Write("Instructions: ");
            instruction.ForEach(x => Console.Write(x));
            Console.WriteLine();
        }
    }
}
