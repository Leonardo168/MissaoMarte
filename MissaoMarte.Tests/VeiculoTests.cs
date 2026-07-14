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
}
