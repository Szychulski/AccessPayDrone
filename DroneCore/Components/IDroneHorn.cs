using System;
using System.Collections.Generic;
using System.Text;

namespace DroneCore.Components
{
    public interface IDroneHorn
    {
        void Alert(TimeSpan time);
    }
}
