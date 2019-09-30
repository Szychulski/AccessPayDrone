using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.Navigation
{
    public interface INavModule
    {
        MoveResult Move(TimeSpan timeSpan, int directionAngle);
    }
}
