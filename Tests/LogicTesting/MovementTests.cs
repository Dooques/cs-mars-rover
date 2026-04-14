using MarsRover.Model;
using MarsRover.Logic;

namespace Tests.Logic;

public class MovementTests
{
    [TestCase(Direction.North, Direction.West)]
    [TestCase(Direction.West, Direction.South)]
    [TestCase(Direction.South, Direction.East)]
    [TestCase(Direction.East, Direction.North)]
    public void Rotate_RotateLeft_PassLInput(Direction startingDirection, Direction endDirection)
    {
        Rover rover = new Rover("Alpha", new Position(2, 2, startingDirection));

        rover.Rotate(Instruction.L);

        Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(endDirection));
    }

    [TestCase(Direction.North, Direction.East)]
    [TestCase(Direction.East, Direction.South)]
    [TestCase(Direction.South, Direction.West)]
    [TestCase(Direction.West, Direction.North)]
    public void Rotate_RotateRight_PassRInput(Direction startingDirection, Direction endDirection)
    {
        Rover rover = new Rover("Alpha", new Position(2, 2, startingDirection));

        rover.Rotate(Instruction.R);

        Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(endDirection));
    }

    [Test]
    public void Rotate_StaySationary_PassMInput()
    {
        Rover rover = new Rover("Alpha", new Position(2, 2, Direction.North));

        rover.Rotate(Instruction.M);

        Assert.That(rover.CurrentPosition.Direction, Is.EqualTo(Direction.North));
    }

    [TestCase(Direction.North, 2, 3)]
    [TestCase(Direction.South, 2, 1)]
    [TestCase(Direction.East, 3, 2)]
    [TestCase(Direction.West, 1, 2)]
    public void MoveForward_Move_PassedInput(Direction startingDirection, int expectedX, int expectedY)
    {
        Rover rover = new Rover("Alpha", new Position(2, 2, startingDirection));

        rover.MoveForward(Instruction.M);
        Assert.That(rover.CurrentPosition.X, Is.EqualTo(expectedX));
        Assert.That(rover.CurrentPosition.Y, Is.EqualTo(expectedY));
    }
}
