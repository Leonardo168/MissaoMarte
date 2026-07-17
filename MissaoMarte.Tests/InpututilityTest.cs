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
        public void TestCapturarInput_excessao(string inputLinha)
        {
            // Arrange
            Console.SetIn(new StringReader(inputLinha));

            // Act
            Action act = () => InputUtility.CapturarInput("TestCapturarInput_excessao: ");

            // Assert
            var ex = Assert.ThrowsExactly<ArgumentException>(act);
            Assert.AreEqual("Input invalido.", ex.Message);
        }
    }
}