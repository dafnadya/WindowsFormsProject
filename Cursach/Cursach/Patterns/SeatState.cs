using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.Patterns
{
    [DataContract]
    abstract class SeatState
    {
        abstract public int CountAddedValue();
        abstract public Color GetSeatColour();
    }

    [DataContract]
    class CheapSeat : SeatState
    {
        override public int CountAddedValue()
        {
            return 0;
        }
        override public Color GetSeatColour()
        {
            return Color.LightSkyBlue;
        }
    }

    [DataContract]
    class OrdinarySeat : SeatState
    {
        override public int CountAddedValue()
        {
            return 10;
        }
        override public Color GetSeatColour()
        {
            return Color.Blue;
        }
    }

    [DataContract]
    class LuxSeat : SeatState
    {
        override public int CountAddedValue()
        {
            return 20;
        }
        override public Color GetSeatColour()
        {
            return Color.DarkBlue;
        }
    }
}
