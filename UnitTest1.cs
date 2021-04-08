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
            var rhombus = new Rhombus(new MockTemp());
            var result = rhombus.Perimeter(2);
            var expected = 8;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForArea1()
        {
            var rhombus = new Rhombus(new MockTemp());
            var result = rhombus.Area(2, 5);
            var expected = 10;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForPerimeter2()
        {
            var rect = new Rectangle(new MockTemp());
            var result = rect.Perimeter(2, 8);
            var expected = 20;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForArea2()
        {
            var rect = new Rectangle(new MockTemp());
            var result = rect.Area(4, 5);
            var expected = 20;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForPerimeter3()
        {
            var para = new Parallelogram(new MockTemp());
            var result = para.Perimeter(3, 8);
            var expected = 22;

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestForArea3()
        {
            var para = new Parallelogram(new MockTemp());
            var result = para.Area(3, 5);
            var expected = 15;

            Assert.AreEqual(expected, result);
        }
    }
}