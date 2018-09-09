using Microsoft.VisualStudio.TestTools.UnitTesting;
using calcTest.Controllers;

namespace calcTest.Tests
{
    [TestClass]
    public class calcJurosControllerTests
    {
        [TestMethod]
        public void Post_ValoresInvalidos_False()
        {
            //Arrange
            CalcJurosController cJuros = new CalcJurosController();
            cJuros.Post(0, 0);
            decimal valorEsperado = -1M;

            //Act
            decimal valorObtido = cJuros.Get().Value;

            //Assert
            Assert.AreEqual(valorEsperado, valorObtido);
        }

        [TestMethod]
        public void Post_ValoresValidos_True()
        {
            //Arrange
            CalcJurosController cJuros = new CalcJurosController();
            cJuros.Post(90, 2);
            decimal valorEsperado = 8262.81M;

            //Act
            decimal valorObtido = cJuros.Get().Value;

            //Assert
            Assert.AreEqual(valorEsperado, valorObtido);
        }
    }
}
