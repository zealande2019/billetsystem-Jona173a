using BilletLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        /// <summary>
        /// Unittest af Bil pris.
        /// </summary>
        [TestMethod]
        public void PrisTestBil()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            decimal pris = bil.Pris();
            //Assert
            Assert.AreEqual(240, pris);
        }
        /// <summary>
        /// Unittest af Bil køretøj.
        /// </summary>
        [TestMethod]
        public void KøretøjTestBil()
        {
            //Arrange
            Bil bil = new Bil();
            //Act
            string køretøj = bil.Køretøj();
            //Assert
            Assert.AreEqual("Bil", køretøj);
        }
        /// <summary>
        /// Unittest af MC pris.
        /// </summary>
        [TestMethod]
        public void PrisTestMC()
        {
            //Arrange
            MC mc = new MC();
            //Act
            decimal pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }
        /// <summary>
        /// Unittest af MC køretøj.
        /// </summary>
        [TestMethod]
        public void KøretøjTestMC()
        {
            //Arrange
            MC mc = new MC();
            //Act
            string køretøj = mc.Køretøj();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}
