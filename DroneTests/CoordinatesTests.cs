using DroneCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace DroneTests
{
    [TestClass]
    public class CoordinatesTests
    {
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        [TestMethod]
        public void CoordinatesShouldNotAcceptNegativeValues()
        {
            //arrange
            Coordinates c = null;

            //act
            c = new Coordinates(-1, 0);

            //asert - Expects exception
        }

        [TestMethod]
        public void CoordinatesShouldAcceptPositiveValues()
        {
            //arrange
            Coordinates c = null;

            //act
            c = new Coordinates(1, 0);

            //asert
            Assert.AreEqual(1, c.X);
            Assert.AreEqual(0, c.Y);
        }
    }
}
