using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calanna.Cecilia._2A.TPFinal;

namespace TestProjectMarvel
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarFase_CuandoEsMenorAUno_DeberiaRetornarFalse()
        {
            //arrange
            int actual = -2;
            bool expected;
            //act
            expected = Pelicula.ValidarFase(actual);
            //assert
            Assert.IsFalse(expected);
            
        }
        [TestMethod]
        public void ValidarFase_CuandoEsMayorAUno_DeberiaRetornarTrue()
        {
            //arrange
            int actual = 3;
            bool expected;
            //act
            expected = Pelicula.ValidarFase(actual);
            //assert
            Assert.IsTrue(expected);
        }
        [TestMethod]
        public void ValidarFase_CuandoEsMayorACuatro_DeberiaRetornarFalse()
        {
            //arrange
            int actual = 5;
            bool expected;
            //act
            expected = Pelicula.ValidarFase(actual);
            //assert
            Assert.IsFalse(expected);
        }
        
    }
}
