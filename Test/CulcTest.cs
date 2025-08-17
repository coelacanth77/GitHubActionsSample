using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleApp;

namespace Test
{
    [TestClass]
    public sealed class CulcTest
    {
        [TestMethod]
        public void Add_ValidInputs_ReturnsSum()
        {
            Assert.AreEqual(5, Culc.Add(2, 3));
            Assert.AreEqual(0, Culc.Add(-2, 2));
            Assert.AreEqual(-5, Culc.Add(-2, -3));
        }

        [TestMethod]
        public void Subtract_ValidInputs_ReturnsDifference()
        {
            Assert.AreEqual(-3, Culc.Subtract(2, 3));
            Assert.AreEqual(-4, Culc.Subtract(-2, 2));
            Assert.AreEqual(1, Culc.Subtract(-2, -3));
        }

        [TestMethod]
        public void Multiply_ValidInputs_ReturnsProduct()
        {
            Assert.AreEqual(6, Culc.Multiply(2, 3));
            Assert.AreEqual(-4, Culc.Multiply(-2, 2));
            Assert.AreEqual(6, Culc.Multiply(-2, -3));
            Assert.AreEqual(0, Culc.Multiply(0, 5));
        }

        [TestMethod]
        public void Divide_ValidInputs_ReturnsQuotient()
        {
            Assert.AreEqual(2.0, Culc.Divide(6, 3));
            Assert.AreEqual(-1.5, Culc.Divide(-3, 2));
            Assert.AreEqual(1.5, Culc.Divide(3, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ThrowsException()
        {
            Culc.Divide(1, 0);
        }
    }
}