using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursach.Patterns
{
    public interface ITicketPay
    {
        bool PayForTicket(int ticketCost);
        string Status { get; }
    }

    class CashTicket : ITicketPay
    {
        public bool PayForTicket(int ticketCost)
        {
            return true;
        }
        public string Status
        {
            get { return "need to pay"; }
        }
    }

    class CardTicket : ITicketPay
    {
        public bool PayForTicket(int ticketCost)
        {
            if (Cinema.CurUser.CardSum >= ticketCost)
            {
                Cinema.CurUser.CardSum -= ticketCost;
                return true;
            }
            else return false;
        }
        public string Status
        {
            get { return "paid"; }
        }
    }
}
