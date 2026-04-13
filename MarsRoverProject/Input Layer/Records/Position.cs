using System;

namespace MarsRover
{
	internal record Position(int x, int y, Direction compassDirection)
	{
		int X = x;
		int Y = y;
		Direction Compass = compassDirection;
	}
}
