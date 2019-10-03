using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using minhtam4b;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestIsContain5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program2.IsContain5(Arr1);
            Assert.AreEqual(true,result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool result2 = Program2.IsContain5(Arr2);
            Assert.AreEqual(false,result2);
        }
        [TestMethod]
        public void TestIsContain5or6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 };
            bool result1 = Program2.IsContain5or6(Arr1);
            Assert.AreEqual(true, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 7 };
            bool result2 = Program2.IsContain5or6(Arr2);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void TestIsContain5and6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5 ,6};
            bool result1 = Program2.IsContain5and6(Arr1);
            Assert.AreEqual(true, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
            bool result2 = Program2.IsContain5and6(Arr2);
            Assert.AreEqual(false, result2);
        }
        [TestMethod]
        public void Testcount5()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int result1 = Program2.count5(Arr1);
            Assert.AreEqual(1, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 6 };
            int result2 = Program2.count5(Arr2);
            Assert.AreEqual(0, result2);
        }
        [TestMethod]
        public void Testcount5or6()
        {
            int[] Arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int result1 = Program2.count5or6(Arr1);
            Assert.AreEqual(2, result1);

            int[] Arr2 = new int[] { 1, 2, 3, 4, 7 };
            int result2 = Program2.count5or6(Arr2);
            Assert.AreEqual(0, result2);
        }
    }
}
