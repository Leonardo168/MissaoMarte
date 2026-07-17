using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissaoMarte.App.Utilities;

namespace MissaoMarte.Tests
{
    [DoNotParallelize]
    [TestClass]
    public sealed class InputUtilityTest
    {
        [TestMethod]
        [DataRow("1 1 N")]
        public void TestCapturarInput(string inputLinha)
        {
            // Arrange
            string[] inputPartes;
            Console.SetIn(new StringReader(inputLinha));

            // Act
            inputPartes = InputUtility.CapturarInput(" ");
            string inputReconstruido = string.Join(" ", inputPartes);

            // Assert
            Assert.AreEqual(inputLinha, inputReconstruido);
        }

        [TestMethod]
        [DataRow("")]
        public void TestCapturarInput_Excessao(string inputLinha)
        {
            // Arrange
            Console.SetIn(new StringReader(inputLinha));

            // Act
            Action act = () => InputUtility.CapturarInput("TestCapturarInput_excessao: ");

            // Assert
            var ex = Assert.ThrowsExactly<ArgumentException>(act);
            Assert.AreEqual("Input invalido.", ex.Message);
        }

        [TestMethod]
        [DataRow(new[] { "1", "1" })]
        public void TestCapturarCoordenadasCampoDePouso(string[] inputPartes)
        {
            // Arrange
            int coordX, coordY;

            // Act
            InputUtility.CapturarCoordenadasCampoDePouso(inputPartes, out coordX, out coordY);

            // Assert
            Assert.AreEqual(inputPartes[0], coordX.ToString());
            Assert.AreEqual(inputPartes[1], coordY.ToString());
        }

        [TestMethod]
        [DataRow(new[] { "S", "1" })]
        [DataRow(new[] { "1", "-1" })]
        public void TestCapturarCoordenadasCampoDePouso_Excessao(string[] inputPartes)
        {
            // Arrange
            int coordX, coordY;

            // Act
            Action act = () => InputUtility.CapturarCoordenadasCampoDePouso(inputPartes, out coordX, out coordY);

            // Assert
            var ex = Assert.ThrowsExactly<ArgumentException>(act);
            Assert.AreEqual("Coordenadas invalidas.", ex.Message);
        }

        [TestMethod]
        [DataRow(new[] { "1", "1", "N" })]
        public void TestCapturarPosicaoVeiculo(string[] inputPartes)
        {
            // Arrange
            int coordX, coordY;
            char direcao;

            // Act
            InputUtility.CapturarPosicaoVeiculo(inputPartes, out coordX, out coordY, out direcao);

            // Assert
            Assert.AreEqual(inputPartes[0], coordX.ToString());
            Assert.AreEqual(inputPartes[1], coordY.ToString());
            Assert.AreEqual(inputPartes[2], direcao.ToString());
        }

        [TestMethod]
        [DataRow(new[] { "1", "1", "A" })]
        [DataRow(new[] { "-1", "1", "N" })]
        [DataRow(new[] { "1", "S", "N" })]
        public void TestCapturarPosicaoVeiculo_Excessao(string[] inputPartes)
        {
            // Arrange
            int coordX, coordY;
            char direcao;

            // Act
            Action act = () => InputUtility.CapturarPosicaoVeiculo(inputPartes, out coordX, out coordY, out direcao);

            // Assert
            var ex = Assert.ThrowsExactly<ArgumentException>(act);
            Assert.AreEqual("Posicao invalida.", ex.Message);
        }
    }
}