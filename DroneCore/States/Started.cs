using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.States
{
    internal class Started : DroneState
    {
        public Started(Drone drone) : base(drone) { }

        public override void Restart() => throw new InvalidOperationException("Cannot restart just started drone.");

        public override void SetBoundary(Coordinates coordinates)
        {
            _drone.State = new Initiated(_drone, coordinates);
        }

        public override void SetInitialPosition(Coordinates coordinates) => throw new InvalidOperationException("Cannot set initial position on just started drone.");

        public override void Shutdown()
        {
            _drone.State = new Created(_drone);
        }

        public override void Start() => throw new InvalidOperationException("Cannot start just started drone.");
    }
}
