using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTD_Laba_1;

namespace UnitTestMTD_Laba1
{
    class MockTemp : ITemp
    {
        public void Temp(object o)
        {
            Console.WriteLine(o);
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForPerimeter1()
        {
            var rhombus = new Rhombus(2, 5);
            var result = rhombus.Perimeter();
            var expected = 8;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForArea1()
        {
            var rhombus = new Rhombus(2, 5);
            var result = rhombus.Area();
            var expected = 10;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForPerimeter2()
        {
            var rect = new Rectangle(2, 8);
            var result = rect.Perimeter();
            var expected = 20;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForArea2()
        {
            var rect = new Rectangle(4, 5);
            var result = rect.Area();
            var expected = 20;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForPerimeter3()
        {
            var para = new Parallelogram(3, 8, 5);
            var result = para.Perimeter();
            var expected = 22;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForArea3()
        {
            var para = new Parallelogram(3, 8, 5);
            var result = para.Area();
            var expected = 15;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForArea4()
        {
            var sqr = new Square(3);
            var result = sqr.Area();
            var expected = 9;

            Assert.AreEqual(expected, result);
        }
    }
}
