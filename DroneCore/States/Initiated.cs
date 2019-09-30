using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.States
{
    internal class Initiated : DroneState
    {
        public Initiated(Drone drone, Coordinates boundaries) : base(drone)
        {
            Boundary = boundaries;
        }

        public override void Restart()
        {
            _drone.State = new Started(_drone);
        }

        public override void SetBoundary(Coordinates coordinates) => throw new InvalidOperationException("Cannot set boundaries on initiated drone");

        public override void SetInitialPosition(Coordinates coordinates)
        {
            //TODO: add checking if initial position is inside boundaries
            InitialPosition = coordinates;
            _drone.State = this;
        }

        public override void Shutdown()
        {
            _drone.State = new Created(_drone);
        }

        public override void Start() => throw new InvalidOperationException("Cannot start initiated drone");
    }
}
