using System;
using AreaCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalcTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void ConstructorThrowsWhenRadiusNegative()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-5),
                "Must throw ArgumentException when radius is negative");
        }

        [TestMethod]
        public void ConstructorThrowsWhenRadiusIsZero()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(0),
                "Must throw ArgumentException when radius is zero");
        }

        [TestMethod]
        public void AreaIsCalculatedCorrectly()
        {
            var radius = 5;
            var circle = new Circle(radius);
            Assert.AreEqual(circle.CalculateArea(), Math.PI * radius * radius);
        }
    }
}
