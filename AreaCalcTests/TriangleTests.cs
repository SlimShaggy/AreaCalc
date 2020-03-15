using System;
using AreaCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalcTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [DataRow(-5, 1, 2 )]
        [DataRow( 1, -5, 2 )]
        [DataRow( 1, 2, -5)]
        public void ConstructorThrowsWhenAnySideIsNegative(int side1, int side2, int side3)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [TestMethod]
        [DataRow(0, 1, 2 )]
        [DataRow( 1, 0, 2 )]
        [DataRow( 1, 2, 0)]
        public void ConstructorThrowsWhenAnySideIsZero(int side1, int side2, int side3)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [TestMethod]
        public void ConstructorThrowsWhenTriangleIsInvalid()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 2, 4));
        }

        [TestMethod]
        public void IsRightIsTrueForRightTriangle()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRight);
        }

        [TestMethod]
        public void IsRightIsFalseForObliqueTriangle()
        {
            var triangle = new Triangle(5, 29, 30);
            Assert.IsFalse(triangle.IsRight);
        }

        [TestMethod]
        public void RightTriangleAreaIsCalculatedCorrectly()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(triangle.CalculateArea(), 6);
        }

        [TestMethod]
        public void ObliqueTriangleAreaIsCalculatedCorrectly()
        {
            var triangle = new Triangle(5, 29, 30);
            Assert.AreEqual(triangle.CalculateArea(), 72);
        }
    }
}
