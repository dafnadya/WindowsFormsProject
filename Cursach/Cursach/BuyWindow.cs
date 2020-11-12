using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cursach.Patterns;
using System.Threading;

namespace Cursach
{
    public partial class BuyWindow : Form
    {
        private ProxyTicket _ticket;
        private Seat _seat;

        public BuyWindow(ProxyTicket ticket, Seat seat)
        {
            _ticket = ticket;
            _seat = seat;
            InitializeComponent();
            label3.Text = ticket.CountCurrentCost() + " hrn";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cardButton.Checked) _ticket.TicketPay = new CardTicket();
            else _ticket.TicketPay = new CashTicket();
            if (!_ticket.PayForTicket())
            {
                MessageBox.Show("Not enought money on card", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _seat.TakeSeat();

            Ticket totalTicket = _ticket.GetTicket();
            Cinema.CurUser.AddTicket(totalTicket);

            Close();
        }
    }
}
