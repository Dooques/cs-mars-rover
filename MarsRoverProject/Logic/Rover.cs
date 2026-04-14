using MarsRover.Logic;
using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Rover: IMovable
    {
        public string Name { get; private set; }
        public Position CurrentPosition { get; private set; }

        public Rover(string name, Position position)
        {
            if (name == "")
            {
                throw new FormatException("Rover Name is Empty");
            }
            if (position.Direction is Direction.None)
            {
                throw new FormatException("Direction is invalid");
            }
            if (position.X < 0 || position.Y < 0)
            {
                throw new FormatException("Starting position must be positive");
            }


            Name = name;
            CurrentPosition = position;
        }

        public void MoveForward(Instruction instruction)
        {
            var moveDirection = CurrentPosition.Direction;
            switch (moveDirection)
            {
                case Direction.North:
                    CurrentPosition.Y += 1;
                    break;
                case Direction.South:
                    CurrentPosition.Y -= 1;
                    break;
                case Direction.East:
                    CurrentPosition.X += 1;
                    break;
                case Direction.West:
                    CurrentPosition.X -= 1;
                    break;
            }
            return;
        }

        public void Rotate(Instruction instruction)
        {
            List<Direction> directionList = [Direction.North, Direction.East, Direction.South, Direction.West];

            var currentDirectionAsInt = (int)CurrentPosition.compassDirection;
            var newDirection = instruction switch
            {
                Instruction.L => (currentDirectionAsInt - 1),
                Instruction.R => (currentDirectionAsInt + 1),
                _ => currentDirectionAsInt
            };

            var overflow = newDirection switch
            {
                0 => 4,
                5 => 1,
                _ => newDirection
            };

            Console.WriteLine((int)overflow);
            CurrentPosition.Direction = (Direction) overflow;
        }
    }
}
