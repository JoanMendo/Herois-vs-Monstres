using Constants;
using Metodos;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int startGame = Nums.Zero;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Nums.Zero, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int startGame = Nums.One;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Nums.One, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int startGame = Nums.Two;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Nums.Two, result);
        }

    }
}