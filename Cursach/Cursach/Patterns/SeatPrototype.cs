using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.Patterns
{
    public enum SeatType
    {
        Cheap,
        Ordinary,
        Lux
    }

    [DataContract]
    public abstract class SeatPrototype
    {
        public abstract SeatPrototype Clone();
    }

    [KnownType(typeof(SeatState))]
    [KnownType(typeof(CheapSeat))]
    [KnownType(typeof(OrdinarySeat))]
    [KnownType(typeof(LuxSeat))]
    [DataContract]
    public class Seat : SeatPrototype
    {
        [DataMember]
        private int _number;
        [DataMember]
        private int _row;
        [DataMember]
        private bool _isFree;
        [DataMember]
        private SeatState _state;

        private CheapSeat cheap = new CheapSeat();
        private OrdinarySeat ordinary = new OrdinarySeat();
        private LuxSeat lux = new LuxSeat();

        public Seat(int number, SeatType type)
        {
            _isFree = true;
            _number = number;
            if (number == 0 || number % 10 != 0)
                _row = number / 10 + 1;
            else _row = number / 10;
            SetSeatState(type);
        }

        public int Number
        {
            set { _number = value; }
            get { return _number; }
        }
        public int Row
        {
            get { return _row; }
        }
        public bool IsFree
        {
            get { return _isFree; }
        }

        public override SeatPrototype Clone()
        {
            SeatPrototype clone = null;
            try
            {
                clone = this.MemberwiseClone() as SeatPrototype;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return clone;
        }

        protected void SetSeatState(SeatType type)
        {
            if (type == SeatType.Cheap)
                _state = cheap;
            else if (type == SeatType.Ordinary)
                _state = ordinary;
            else
                _state = lux;
        }

        public int CountAddedValue()
        {
            return _state.CountAddedValue();
        }

        public Color GetSeatColour()
        {
            return _state.GetSeatColour();
        }

        public bool TakeSeat()
        {
            if (_isFree)
            {
                _isFree = false;
                return true;
            }
            return false;
        }
    }
}
