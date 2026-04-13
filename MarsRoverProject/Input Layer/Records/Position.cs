using System;

namespace MarsRover
{
	public record Position(int x, int y, Direction compassDirection)
	{
		int X = x;
		int Y = y;
		Direction Compass = compassDirection;
	}
}
