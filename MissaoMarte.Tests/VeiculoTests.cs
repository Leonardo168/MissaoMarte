namespace MissaoMarte.Tests;

[TestClass]
public sealed class VeiculoTests
{
    [TestMethod]
    [DataRow(0, 0, 'N')]
    public void TestConstrutor(int coordX, int coordY, char direcao)
    {
        // Arrange

        // Act
        var veiculo = new Veiculo(coordX, coordY, direcao);

        // Assert
        Assert.IsNotNull(veiculo);
        Assert.AreEqual(coordX, veiculo.CoordX);
        Assert.AreEqual(coordY, veiculo.CoordY);
        Assert.AreEqual(direcao, veiculo.Direcao);
    }

    [TestMethod]
    [DataRow(0, 0, 'L')]
    public void TestIncrementarCoordX(int coordX, int coordY, char direcao)
    {
        // Arrange
        var veiculo = new Veiculo(coordX, coordY, direcao);

        // Act
        veiculo.IncrementarCoordX();

        // Assert
        Assert.AreEqual(coordX + 1, veiculo.CoordX);
    }

    [TestMethod]
    [DataRow(0, 0, 'N')]
    public void TestIncrementarCoordY(int coordX, int coordY, char direcao)
    {
        // Arrange
        var veiculo = new Veiculo(coordX, coordY, direcao);

        // Act
        veiculo.IncrementarCoordY();

        // Assert
        Assert.AreEqual(coordY + 1, veiculo.CoordY);
    }

    [TestMethod]
    [DataRow(1, 0, 'O')]
    public void TestDecrementarCoordX(int coordX, int coordY, char direcao)
    {
        // Arrange
        var veiculo = new Veiculo(coordX, coordY, direcao);

        // Act
        veiculo.DecrementarCoordX();

        // Assert
        Assert.AreEqual(coordX - 1, veiculo.CoordX);
    }

    [TestMethod]
    [DataRow(1, 0, 'S')]
    public void TestDecrementarCoordY(int coordX, int coordY, char direcao)
    {
        // Arrange
        var veiculo = new Veiculo(coordX, coordY, direcao);

        // Act
        veiculo.DecrementarCoordY();

        // Assert
        Assert.AreEqual(coordY - 1, veiculo.CoordY);
    }
}
