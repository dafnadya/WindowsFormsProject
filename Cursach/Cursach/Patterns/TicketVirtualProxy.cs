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
    public abstract class VirtualTicket
    {
        [DataMember]
        protected string cinemaName;
        [DataMember]
        protected string movieName;
        [DataMember]
        protected int cost;
        [DataMember]
        protected int minAge;
        [DataMember]
        protected DateTime time;
        [DataMember]
        protected int hallNumber;
        [DataMember]
        protected string hallType;
        [DataMember]
        protected int seatNumber;
        [DataMember]
        protected int seatRow;
        [DataMember]
        protected string payStatus;
        public abstract Ticket GetTicket();
    }

    [DataContract]
    public class Ticket : VirtualTicket
    {
        public Ticket (string cinemaName, string movie, int cost, int age, 
            int hallNumber, string hallType, int seat, int row, string payStatus, DateTime time)
        {
            this.cinemaName = cinemaName;
            this.movieName = movie;
            this.cost = cost;
            this.minAge = age;
            this.hallNumber = hallNumber;
            this.hallType = hallType;
            this.seatNumber = seat;
            this.seatRow = row;
            this.payStatus = payStatus;
            this.time = time;
        }

        public DateTime Time
        {
            get { return time; }
        }

        public override Ticket GetTicket()
        {
            return this;
        }

        public override string ToString()
        {
            return $"{cinemaName} cinema\n{movieName}\n{minAge}+\nTime: {time}\nHall {hallNumber} " +
                $"({hallType})\nRow: {seatRow}, seat: {seatNumber}\nCost: {cost} hrn ({payStatus})";
        }

        public string ToStringShort()
        {
            return $"{movieName} ({time})";
        }
    }
    
    public class ProxyTicket : VirtualTicket
    {
        Ticket ticket;

        private Movie _movie;
        private bool _isStudent;
        private Seance _seance;
        private Seat _seat;
        private ITicketPay _ticketPay;

        public string CinemaName { set { cinemaName = value; } }
        public Movie Movie { set { _movie = value; } }
        public bool IsStudent { set { _isStudent = value; } }
        public Seance Seance { set { _seance = value; } }
        public Seat Seat { set { _seat = value; } }
        public ITicketPay TicketPay { set { _ticketPay = value; } }

        public bool PayForTicket()
        {
            cost = CountCurrentCost();

            if (_ticketPay.PayForTicket(cost))
            {
                payStatus = _ticketPay.Status;
                return true;
            }
            return false;
        }

        public int CountCurrentCost()
        {
            int curCost = 0;
            if (_movie != null)
            {
                if (_movie.Type == FilmType.Premiere)
                {
                    PremiereMarkup pm = new PremiereMarkup(_movie);
                    curCost = pm.GetPrice();
                }
                else if (_movie.Type == FilmType.StudentSale && _isStudent)
                {
                    StudentSale ss = new StudentSale(_movie);
                    curCost = ss.GetPrice();
                }
                else
                    curCost = _movie.GetPrice();

                if (_seance != null)
                {
                    curCost += _seance.SeancePaid;
                    curCost += _seance.Hall.HallPaid;
                    if (_seat != null)
                        curCost += _seat.CountAddedValue();
                }
            }
            if (Cinema.CurUser != null) curCost = (int)(curCost * Cinema.CurUser.Discount);
            return curCost;
        }

        public override Ticket GetTicket()
        {
            if (ticket == null)
            {
                ticket = new Ticket(cinemaName, _movie.Name, cost, _movie.MinAge, _seance.Hall.Number,
                    _seance.Hall.HallType, _seat.Number, _seat.Row, payStatus,
                    _seance.Time);
            }

            return ticket.GetTicket();
        }

        public override string ToString()
        {
            if (ticket == null)
            {
                return "Error";
            }
            return ticket.ToString();
        }
    }
}
