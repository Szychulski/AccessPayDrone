using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.Commands
{
    public class ToggleLights : ICommand
    {
        private readonly Drone _drone;

        public ToggleLights(Drone drone)
        {
            _drone = drone;
        }

        public void Execute()
        {
            _drone.ToggleLights();
        }
    }
}
