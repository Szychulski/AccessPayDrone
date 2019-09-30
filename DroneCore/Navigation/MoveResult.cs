using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.Navigation
{
    public class MoveResult
    {
        public Coordinates CurrentPosition { get; private set; }
        public bool TriedToCrossBorder { get; private set; }

        public MoveResult(Coordinates currentPosition, bool triedToCrossBorded)
        {
            CurrentPosition = currentPosition;
            TriedToCrossBorder = triedToCrossBorded;
        }
    }

}
