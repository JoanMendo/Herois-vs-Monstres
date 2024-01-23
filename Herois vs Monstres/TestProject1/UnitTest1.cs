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

        [TestMethod]
        public void TestNamesErrorTester1()
        {
            string[] names = { };

            // Act
            int result = Class2.ErrorTester(names);

            // Assert
            Assert.AreEqual(Const.One, result);
        }

        [TestMethod]
        public void TestNamesErrorTester2()
        {
            string[] names = { "a", "afeasfesa", "affafef", "fwreerrwqe" };

            // Act
            int result = Class2.ErrorTester(names);

            // Assert
            Assert.AreEqual(Const.One, result);
        }

        [TestMethod]
        public void TestNamesErrorTester3()
        {
            string[] names = { "a", "afeasfesa", "affafef", "fwreerrwqe", "awdafefeaf", "f8wfj98wf" };

            // Act
            int result = Class2.ErrorTester(names);

            // Assert
            Assert.AreEqual(Const.One, result);
        }

        [TestMethod]
        public void TestNamesErrorTester4()
        {
            string[] names = { "afeasfesa", "affafef", "fwreerrwqe", "awdafefeaf", "f8wfj98wf" };

            // Act
            int result = Class2.ErrorTester(names);

            // Assert
            Assert.AreEqual(Const.Zero, result);
        }

        [TestMethod]
        public void TestStatErrorTester1()
        {
            int i = 0, j = 0;
            double[,] doubles = new double[3, 5];
            doubles[i, j] = 1500;

            // Act
            bool result = Class2.ErrorTester(doubles, i, j);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestStatErrorTester2()
        {
            int i = 0, j = 0;
            double[,] doubles = new double[3, 5];
            doubles[i, j] = 2000;

            // Act
            bool result = Class2.ErrorTester(doubles, i, j);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestStatErrorTester3()
        {
            int i = 0, j = 0;
            double[,] doubles = new double[3, 5];
            doubles[i, j] = 1499;

            // Act
            bool result = Class2.ErrorTester(doubles, i, j);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestStatErrorTester4()
        {
            int i = 0, j = 0;
            double[,] doubles = new double[3, 5];
            doubles[i, j] = 2001;

            // Act
            bool result = Class2.ErrorTester(doubles, i, j);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestActionErrorTester1()
        {
            int i = 0;

            // Act
            bool result = Class2.ErrorTester(i);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestActionErrorTester2()
        {
            int i = 1;


            // Act
            bool result = Class2.ErrorTester(i);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestActionErrorTester3()
        {
            int i = 4;


            // Act
            bool result = Class2.ErrorTester(i);

            // Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void TestActionErrorTester4()
        {
            int i = 3;


            // Act
            bool result = Class2.ErrorTester(i);

            // Assert
            Assert.AreEqual(true, result);



        }
       

             [TestMethod]
        public void TestCharactersAliveTester1()
        {
            int i = 3;
            string[] namesArray = { "a", "afeasfesa", "affafef", "fwreerrwqe", "awdafefeaf" };
            double[,] EasyStats = { { 2000, 3750, 1500, 2500, 7000 }, { 300, 250, 400, 120, 300 }, { 35, 45, 35, 40, 20 } };


            // Act
            bool result = Class2.CharactersAliveTester(i, namesArray, EasyStats);

            // Assert
            Assert.AreEqual(true, result);



        }
        [TestMethod]
        public void TestCharactersAliveTester2()
        {
            int i = 3;
            string[] namesArray = { "a", "afeasfesa", "affafef", "fwreerrwqe", "awdafefeaf" };
            double[,] EasyStats = { { 2000, 3750, 1500, -10, 7000 }, { 300, 250, 400, 120, 300 }, { 35, 45, 35, 40, 20 } };


            // Act
            bool result = Class2.CharactersAliveTester(i, namesArray, EasyStats);

            // Assert
            Assert.AreEqual(false, result);



        }

        [TestMethod]

        public void TestDruidHealing1()
        {

            double[,] stats = { { 1500, 3250, 1000, 2000, 7000 }, { 300, 250, 400, 120, 300 }, { 35, 45, 35, 40, 20 } };
            string[] names = { "a", "afeasfesa", "affafef", "fwreerrwqe", "awdafefeaf" };

            double[,] result = Class2.DruidHealing(stats, names);

            Assert.AreEqual(Const.EasyStats, result);
        }

        [TestMethod]
        public void TestDruidHealing2()
        {

            double[,] stats = { { 1800, 3650, 1400, 2400, 7000 }, { 300, 250, 400, 120, 300 }, { 35, 45, 35, 40, 20 } };
            string[] names = { "a", "afeasfesa", "affafef", "fwreerrwqe", "awdafefeaf" };

            double[,] result = Class2.DruidHealing(stats, names);

            Assert.AreEqual(Const.EasyStats, result);
        }
        [TestMethod]
        public void TestDruidHealing3()
        {

            double[,] stats = { { 100, 300, 100, 200, 7000 }, { 300, 250, 400, 120, 300 }, { 35, 45, 35, 40, 20 } };
            string[] names = { "a", "afeasfesa", "affafef", "fwreerrwqe", "awdafefeaf" };

            double[,] result = Class2.DruidHealing(stats, names);

            Assert.AreNotEqual(Const.EasyStats, result);
        }
    }
}