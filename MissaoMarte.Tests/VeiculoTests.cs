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

    [TestMethod]
    [DataRow(0, 0, 'N', 'L')]
    [DataRow(0, 0, 'L', 'S')]
    [DataRow(0, 0, 'S', 'O')]
    [DataRow(0, 0, 'O', 'N')]
    public void TestVirarDireita(int coordX, int coordY, char direcao, char direcaoEsperada)
    {
        // Arrange
        var veiculo = new Veiculo(coordX, coordY, direcao);

        // Act
        veiculo.VirarDireita();

        // Assert
        Assert.AreEqual(direcaoEsperada, veiculo.Direcao);
    }

    [TestMethod]
    [DataRow(0, 0, 'N', 'O')]
    [DataRow(0, 0, 'O', 'S')]
    [DataRow(0, 0, 'S', 'L')]
    [DataRow(0, 0, 'L', 'N')]
    public void TestVirarEsquerda(int coordX, int coordY, char direcao, char direcaoEsperada)
    {
        // Arrange
        var veiculo = new Veiculo(coordX, coordY, direcao);

        // Act
        veiculo.VirarEsquerda();

        // Assert
        Assert.AreEqual(direcaoEsperada, veiculo.Direcao);
    }

    [TestMethod]
    [DataRow(0, 0, 'N', 0, 1)]
    [DataRow(0, 0, 'L', 1, 0)]
    [DataRow(0, 1, 'S', 0, 0)]
    [DataRow(1, 0, 'O', 0, 0)]
    public void TestAvancar(int coordX, int coordY, char direcao, int coordXEsperada, int coordYEsperada)
    {
        // Arrange
        var veiculo = new Veiculo(coordX, coordY, direcao);

        // Act
        veiculo.Avancar();

        // Assert
        Assert.AreEqual(coordXEsperada, veiculo.CoordX);
        Assert.AreEqual(coordYEsperada, veiculo.CoordY);
    }
}
