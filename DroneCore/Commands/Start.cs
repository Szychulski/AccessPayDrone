using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.Commands
{
    public class Start : ICommand
    {
        private readonly Drone _drone;

        public Start(Drone drone)
        {
            _drone = drone;
        }

        public void Execute()
        {
            _drone.Start();
        }
    }
}
