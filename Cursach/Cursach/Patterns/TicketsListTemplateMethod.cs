using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach.Patterns
{
    abstract class TicketsList
    {
        public virtual void AddTicket(ListView ticketsList, Ticket ticket)
        {
            ListViewItem item = new ListViewItem();
            item.Text = ticket.ToStringShort();
            item.Tag = ticket;
            ticketsList.Items.Add(item);
        }

        // The 'Template Method'
        public void SetTickets(ListView ticketsList)
        {
            ticketsList.Clear();
            List<Ticket> tickets = Cinema.CurUser.Tickets;
            foreach (Ticket ticket in tickets)
            {
                AddTicket(ticketsList, ticket);
            }
        }
    }

    class AllFilmsList : TicketsList { }

    class WatchedFilmsList : TicketsList
    {
        public override void AddTicket(ListView ticketsList, Ticket ticket)
        {
            if (ticket.Time < DateTime.Now)
            {
                base.AddTicket(ticketsList, ticket);
            }
        }
    }

    class ComingFilmsList : TicketsList
    {
        public override void AddTicket(ListView ticketsList, Ticket ticket)
        {
            if (ticket.Time >= DateTime.Now)
            {
                base.AddTicket(ticketsList, ticket);
            }
        }
    }
}
