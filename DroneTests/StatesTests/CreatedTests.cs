using DroneCore;
using DroneCore.States;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DroneTests.StatesTests
{
    [TestClass]
    public class CreatedTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowExceptionWhenTryingToSetBoundry()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var coordinatesMock = new Mock<Coordinates>(null, null);
            var created = new Created(droneMock.Object);

            //act
            created.SetBoundary(coordinatesMock.Object);

            //asert - Expects exception
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowExceptionWhenTryingToRestart()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var created = new Created(droneMock.Object);

            //act
            created.Restart();

            //asert - Expects exception
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowExceptionWhenTryingToSetInitialPosition()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var coordinatesMock = new Mock<Coordinates>(null, null);
            var created = new Created(droneMock.Object);

            //act
            created.SetInitialPosition(coordinatesMock.Object);

            //asert - Expects exception
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowExceptionWhenTryingToShoutdown()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var created = new Created(droneMock.Object);

            //act
            created.Shutdown();

            //asert - Expects exception
        }

        [TestMethod]
        public void ShouldMoveToStartedWhenStarting()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var created = new Created(droneMock.Object);

            //act
            created.Start();

            //assert
            Assert.IsInstanceOfType(droneMock.Object.State, typeof(Started));
        }
    }
}
