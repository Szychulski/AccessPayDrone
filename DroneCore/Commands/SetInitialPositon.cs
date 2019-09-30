using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.Commands
{
    public class SetInitialPositon : ICommand
    {
        private readonly Drone _drone;
        private readonly Coordinates _position;

        public SetInitialPositon(Drone drone, Coordinates position)
        {
            this._drone = drone;
            this._position = position;
        }

        public void Execute()
        {
            _drone.SetInitialPosition(_position);
        }
    }
}
