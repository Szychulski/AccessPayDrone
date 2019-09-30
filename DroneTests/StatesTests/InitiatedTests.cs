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
    public class InitiatedTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowExceptionWhenTryingToSetBoundry()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var coordinatesMock = new Mock<Coordinates>(null, null);
            var initiated = new Initiated(droneMock.Object, coordinatesMock.Object);

            //act
            initiated.SetBoundary(coordinatesMock.Object);

            //assert - Expects exception
        }

        [TestMethod]
        public void ShouldMoveToStartedWhenRestarting()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var coordinatesMock = new Mock<Coordinates>(null, null);
            var initiated = new Initiated(droneMock.Object, coordinatesMock.Object);

            //act
            initiated.Restart();

            //assert
            Assert.IsInstanceOfType(droneMock.Object.State, typeof(Started));
        }

        [TestMethod]
        public void ShouldStayInInitiatedStateWhenSettingInitialPosition()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var coordinatesMock = new Mock<Coordinates>(null, null);
            var initiated = new Initiated(droneMock.Object, coordinatesMock.Object);

            //act
            initiated.SetInitialPosition(coordinatesMock.Object);

            //assert
            Assert.IsInstanceOfType(droneMock.Object.State, typeof(Initiated));
        }

        [TestMethod]
        public void ShouldMoveToCreatedWhenShutdown()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var coordinatesMock = new Mock<Coordinates>(null, null);
            var initiated = new Initiated(droneMock.Object, coordinatesMock.Object);

            //act
            initiated.Shutdown();

            //assert
            Assert.IsInstanceOfType(droneMock.Object.State, typeof(Created));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ShouldThrowExceptionWhenTryingToStart()
        {
            //arrange
            var droneMock = new Mock<Drone>(null);
            var coordinatesMock = new Mock<Coordinates>(null, null);
            var initiated = new Initiated(droneMock.Object, coordinatesMock.Object);

            //act
            initiated.Start();

            //assert  - Expects exception
        }
    }
}
