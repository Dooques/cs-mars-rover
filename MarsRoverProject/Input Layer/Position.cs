using System;

namespace MarsRover
{
	internal record Position(int x, int y, MarsRover.Compass compassDirection)
	{
		int X = x;
		int Y = y;
		Compass Compass = compassDirection;
	}
}
