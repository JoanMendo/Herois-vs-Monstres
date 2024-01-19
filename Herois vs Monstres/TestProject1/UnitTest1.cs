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
            int startGame = Const.Zero;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Const.Zero, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int startGame = Const.One;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Const.One, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int startGame = Const.Two;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Const.Two, result);
        }

    }
}