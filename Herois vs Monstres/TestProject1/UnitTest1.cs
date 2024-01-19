using Constants;
using Metodos;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartingMenu1()
        {
            int startGame = Const.Zero;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Const.Zero, result);
        }
        [TestMethod]
        public void TestStartingMenu2()
        {
            int startGame = Const.One;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Const.One, result);
        }
        [TestMethod]
        public void TestStartingMenu3()
        {
            int startGame = Const.Two;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Const.Two, result);
        }

        [TestMethod]
        public void TestStartingMenu4()
        {
            int startGame = -1;

            // Act
            int result = Class2.StartingMenu(startGame);

            // Assert
            Assert.AreEqual(Const.Two, result);
        }

    }
}