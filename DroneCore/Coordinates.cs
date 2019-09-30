using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DroneCore
{
    public class Coordinates
    {
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public Coordinates(int x, int y)
        {
            var errors = string.Empty;
            if (x < 0)
                errors += "x cannot be lower then zero. ";

            if (y < 0)
                errors += "y cannot be lower then zero";

            if (errors.Any())
                throw new ArgumentOutOfRangeException(errors);

            X = x;
            Y = y;
        }

    }
}
