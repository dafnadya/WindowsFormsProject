using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.Patterns
{
    [DataContract]
    public abstract class ChooseHallStrategy
    {
        public abstract int CountHallPaid();
    }

    [DataContract]
    public class TwoDimentionalHall : ChooseHallStrategy
    {
        public TwoDimentionalHall()
        {
        }
        public override int CountHallPaid()
        {
            int hallCost = 10;
            return hallCost;
        }
        public override string ToString()
        {
            return "2D";
        }
    }

    [DataContract]
    public class ThreeDimentionalHall : ChooseHallStrategy
    {
        public ThreeDimentionalHall()
        {
        }
        public override int CountHallPaid()
        {
            int hallCost = 20;
            return hallCost;
        }
        public override string ToString()
        {
            return "3D";
        }
    }
}
