using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.States
{
    public interface IDroneState
    {
        Coordinates InitialPosition { get; }
        Coordinates Boundary { get; }

        void Start();
        void SetBoundary(Coordinates coordinates);
        void SetInitialPosition(Coordinates coordinates);
        void Shutdown();
        void Restart();

    }
}
