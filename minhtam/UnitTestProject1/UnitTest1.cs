﻿using System;
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
            Assert.AreEqual(true, result4);
        }
        public void Square()
        {
            int result3 = Program.Square(3);
            Assert.AreEqual(8, result3);

            int result4 = Program.Square(4);
            Assert.AreEqual(16, result4);
        }
        public void Cube()
        {
            int result3 = Program.Cube(3);
            Assert.AreEqual(27, result3);

            int result4 = Program.Cube(4);
            Assert.AreEqual(65, result4);
        }
    }
}