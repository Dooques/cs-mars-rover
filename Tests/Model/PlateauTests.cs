using MarsRover.Model;

namespace Tests.Model;

public class PlateauTests
{
    [Test]
    public void Plateau_CreatePlateau_InputValid()
    {
        var plateauSizeTest = new PlateauSize(5, 5);
        int[][] expectedPlateauArray = [[0, 1, 2, 3, 4], [0, 1, 2, 3, 4], [0, 1, 2, 3, 4], [0, 1, 2, 3, 4], [0, 1, 2, 3, 4]];

        var plateauTest = new Plateau(plateauSizeTest.x, plateauSizeTest.y);
        Assert.That(plateauTest.PlateauArray, Is.EqualTo(expectedPlateauArray));
    }

    [Test]
    public void Plateau_ThrowException_InputUses1Values()
    {
        var plateauSizeTest = new PlateauSize(1, 5);

        Assert.Throws<FormatException>(() => new Plateau(plateauSizeTest.x, plateauSizeTest.y));
    }

    [Test]
    public void Plateau_ThrowException_InputUses0Values()
    {
        var plateauSizeTest = new PlateauSize(5, 0);

        Assert.Throws<FormatException>(() => new Plateau(plateauSizeTest.x, plateauSizeTest.y));
    }

    [Test]
    public void Plateau_ThrowException_InputUsesNegativeValues()
    {
        var plateauSizeTest = new PlateauSize(-5, -5);

        Assert.Throws<FormatException>(() => new Plateau(plateauSizeTest.x, plateauSizeTest.y));
    }
}
