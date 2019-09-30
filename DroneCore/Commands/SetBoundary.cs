using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.Commands
{
    public class SetBoundary : ICommand
    {
        private readonly Drone _drone;
        private readonly Coordinates _boundary;

        public SetBoundary(Drone drone, Coordinates boundary)
        {
            _drone = drone;
            _boundary = boundary;
        }

        public void Execute()
        {
            _drone.SetBoundary(_boundary);
        }
    }
}
