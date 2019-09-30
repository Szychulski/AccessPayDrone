using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.States
{
    internal abstract class DroneState : IDroneState
    {
        protected readonly Drone _drone;

        public DroneState(Drone drone)
        {
            _drone = drone;
        }

        public Coordinates InitialPosition { get; protected set; } = new Coordinates(0, 0);
        public Coordinates Boundary { get; protected set; }

        public abstract void SetBoundary(Coordinates coordinates);

        public abstract void SetInitialPosition(Coordinates coordinates);

        public abstract void Restart();

        public abstract void Shutdown();

        public abstract void Start();
    }
}
