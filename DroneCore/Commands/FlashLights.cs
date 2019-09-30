using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.Commands
{
    public class FlashLights : ICommand
    {
        private readonly Drone _drone;

        public FlashLights(Drone drone)
        {
            _drone = drone;
        }

        public void Execute()
        {
            _drone.Flash();
        }
    }
}
