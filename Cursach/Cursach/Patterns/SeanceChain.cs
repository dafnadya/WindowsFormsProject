using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Cursach.Patterns
{
    abstract public class DayPart
    {
        protected DayPart _successor;
        
        public DayPart(DayPart successor)
        {
            _successor = successor;
        }
        
        public DayPart Successor
        {
            set { _successor = value; }
        }
        
        abstract public int CountAddedSceanceCost(DateTime sceanceTime);
    }
    
    public class MorningOrNight : DayPart
    {
        public MorningOrNight(DayPart successor) : base(successor) { }
        
        override public int CountAddedSceanceCost(DateTime sceanceTime)
        {
            if (sceanceTime.Hour < 12 || sceanceTime.Hour == 23)
                return 0;
            else
            {
                if (_successor != null)
                {
                    return _successor.CountAddedSceanceCost(sceanceTime);
                }
                else
                    throw new ApplicationException("ChainOfResponsibility object");
            }
        }
    }

    public class Day : DayPart
    {
        public Day(DayPart successor) : base(successor) { }
        
        override public int CountAddedSceanceCost(DateTime sceanceTime)
        {
            if (sceanceTime.Hour >= 12 && sceanceTime.Hour < 18)
                return 25;
            else
            {
                if (_successor != null)
                {
                    return _successor.CountAddedSceanceCost(sceanceTime);
                }
                else

                    throw new ApplicationException("ChainOfResponsibility object");
            }
        }
    }

    public class Evening : DayPart
    {
        public Evening(DayPart successor) : base(successor) { }
        
        override public int CountAddedSceanceCost(DateTime sceanceTime)
        {
            if (sceanceTime.Hour >= 12 && sceanceTime.Hour < 23)
                return 40;
            else
            {
                if (_successor != null)
                {
                    return _successor.CountAddedSceanceCost(sceanceTime);
                }
                else
                    throw new ApplicationException("ChainOfResponsibility object");
            }
        }
    }

    [DataContract]
    public class Seance
    {
        [DataMember]
        private DateTime _time;
        [DataMember]
        private CinemaHall _hall;
        [DataMember]
        private int _seancePaid;

        DayPart dayPart; // delete

        private Evening _ev;
        private Day _day;
        private MorningOrNight _mn;

        public Seance(DateTime time, CinemaHall hall)
        {
            _time = time;
            _hall = hall;
            _ev = new Evening(null);
            _day = new Day(_ev);
            _mn = new MorningOrNight(_day);
            _seancePaid = _mn.CountAddedSceanceCost(this._time);
        }

        public DateTime Time
        {
            get { return _time; }
        }
        public CinemaHall Hall
        {
            get { return _hall; }
        }
        public int SeancePaid
        {
            get { return _seancePaid; }
        }
    }
}
