using System;
using MarsRover.Input;

namespace MarsRover.Model
{
	public record Position(int x, int y, Direction compassDirection)
	{
		public int X = x;
		public int Y = y;
		public Direction Direction = compassDirection;
	}
}
