using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.Patterns
{
    [DataContract]
    public abstract class CinemaHallPrototype
    {
        public abstract CinemaHallPrototype Clone();
    }

    [KnownType(typeof(ChooseHallStrategy))]
    [KnownType(typeof(TwoDimentionalHall))]
    [KnownType(typeof(ThreeDimentionalHall))]
    [DataContract]
    public class CinemaHall : CinemaHallPrototype
    {
        [DataMember]
        private int _number;
        [DataMember]
        private ChooseHallStrategy _hallType;
        [DataMember]
        private List<Seat> _seats;
        [DataMember]
        private int _currentSeat;

        public CinemaHall(int number, ChooseHallStrategy hallType)
        {
            _number = number;
            _hallType = hallType;
            _seats = new List<Seat>();
            _currentSeat = 1;
            AddRow();
        }
        
        public Seat this[int number]
        {
            get
            {
                return _seats[number];
            }

            set { _seats[number] = value; }
        }

        public List<Seat> Seats
        {
            get
            {
                return _seats;
            }
        }
        public int Number
        {
            get
            {
                return _number;
            }
        }
        public int HallPaid
        {
            get
            {
                return _hallType.CountHallPaid();
            }
        }

        public string HallType
        {
            get
            {
                return _hallType.ToString();
            }
        }

        public override CinemaHallPrototype Clone()
        {
            CinemaHallPrototype clone = null;
            try
            {
                clone = this.MemberwiseClone() as CinemaHallPrototype;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return clone;
        }

        private void AddSeat(Seat seatProt)
        {
            Seat seat = seatProt.Clone() as Seat;
            seat.Number = _currentSeat++;
            _seats.Add(seat);
            _currentSeat++;
        }

        public void AddRow()
        {
            SeatType type;
            if (_currentSeat <= 20) type = SeatType.Cheap;
            else if (_currentSeat > 20 && _currentSeat <= 50)
                type = SeatType.Ordinary;
            else type = SeatType.Lux;

            Seat seatProt = new Seat(_currentSeat, type);
            for (int i = 0; i < 10; i++)
                AddSeat(seatProt);
        }

        public void SetHallType(ChooseHallStrategy hallType)
        {
            _hallType = hallType;
        }
    }
}
