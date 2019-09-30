using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.States
{
    internal class Created : DroneState
    {
        public Created(Drone drone) : base(drone) { }

        public override void SetBoundary(Coordinates coordinates) => throw new InvalidOperationException("Cannot set boundary before starting drone.");

        public override void SetInitialPosition(Coordinates coordinates) => throw new InvalidOperationException("Cannot set initial position before starting drone.");

        public override void Restart() => throw new InvalidOperationException("Cannot restart before starting drone.");

        public override void Shutdown() => throw new InvalidOperationException("Cannot shutdown before starting drone.");

        public override void Start()
        {
            _drone.State = new Started(_drone);
        }
    }
}
