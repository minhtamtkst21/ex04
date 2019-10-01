using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minhtam;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);

        }
        public void TestIsEven()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(false, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(true, result4);

        }
        public void TestIsPrime()
        {
            bool result3 = Program.IsPrime(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsPrime(4);
            Assert.AreEqual(false, result4);
        }
        public void TestSquare()
        {
            int result3 = Program.Square(3);
            Assert.AreEqual(9, result3);

            int result4 = Program.Square(4);
            Assert.AreEqual(16, result4);
        }
        public void TestCube()
        {
            int result3 = Program.Cube(3);
            Assert.AreEqual(27, result3);

            int result4 = Program.Cube(4);
            Assert.AreEqual(64, result4);
        }
        public void TestPow()
        {
            int result3 = Program.Pow(2, 3);
            Assert.AreEqual(8, result3);

            int result4 = Program.Pow(6, 2);
            Assert.AreEqual(36, result4);
        }
        public void TestAbs()
        {
            int result3 = Program.Abs(3);
            Assert.AreEqual(3, result3);

            int result4 = Program.Abs(-9);
            Assert.AreEqual(9, result4);
        }
        public void TestCeil()
        {
            double result3 = Program.Ceil(3.5);
            Assert.AreEqual(4, result3);

            double result4 = Program.Ceil(4.1);
            Assert.AreEqual(5, result4);
        }
        public void TestFloor()
        {
            double result3 = Program.Floor(3.5);
            Assert.AreEqual(3, result3);

            double result4 = Program.Floor(4.1);
            Assert.AreEqual(4, result4);
        }
        public void TestFactorial()
        {
            long result3 = Program.Factorial(3);
            Assert.AreEqual(6, result3);

            long result4 = Program.Factorial(4);
            Assert.AreEqual(24, result4);
        }
    }
}
