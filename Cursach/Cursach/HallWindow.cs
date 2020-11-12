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


namespace Cursach
{
    public partial class HallWindow : Form
    {
        private ProxyTicket _ticket;
        private Movie _movie;

        public HallWindow(int selectedMovieIndex)
        {
            Cinema cinema = Cinema.GetCinema();
            _movie = cinema.Movies[selectedMovieIndex];
            _ticket = new ProxyTicket();
            _ticket.CinemaName = cinema.Name;
            InitializeComponent();
            SetMovieSeances(cinema.Movies, selectedMovieIndex);
            if (Cinema.CurUser == null) enterLabel.Visible = true;
        }

        public void SetMovieSeances(List<Movie> movies, int selectedMovieIndex)
        {
            _ticket.Movie = movies[selectedMovieIndex];

            if (movies[selectedMovieIndex].Type == FilmType.StudentSale)
            {
                DialogResult confirmResult = MessageBox.Show("Are you student?",
                                     "Student sale",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _ticket.IsStudent = true;
                }
                else
                {
                    _ticket.IsStudent = false;
                }
            }

            ticketCostLabel.Text = _ticket.CountCurrentCost() + " hrn";

            foreach (Seance seance in movies[selectedMovieIndex].Seances)
            {
                seanceListBox.Items.Add(seance.Time.ToShortTimeString());
            }
        }

        private void EnableBuyButton()
        {
            if (hallView.SelectedCells.Count == 0) return;
            DataGridViewCell selecteSeat = hallView.SelectedCells[0];
            if (selecteSeat != null && selecteSeat.Value != null)
            {
                Seat selectedSeat = _movie.Seances[seanceListBox.SelectedIndex].Hall.Seats[(int)selecteSeat.Value - 1];
                if (selectedSeat != null && selectedSeat.IsFree)
                {
                    buyButton.Enabled = true;
                    _ticket.Seat = selectedSeat;
                    ticketCostLabel.Text = _ticket.CountCurrentCost() + " hrn";
                    return;
                }
            }
            buyButton.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seanceListBox.SelectedIndex == -1) return;
            _ticket.Seat = null;
            hallView.Rows.Clear();
            hallView.Visible = true;
            if (Cinema.CurUser != null) buyButton.Visible = true;

            int index = seanceListBox.SelectedIndex;
            Seance curSeance = _movie.Seances[index];
            _ticket.Seance = curSeance;
            hallTypeLabel.Text = curSeance.Hall.HallType;
            ticketCostLabel.Text = _ticket.CountCurrentCost() + " hrn";

            List<Seat> seats = curSeance.Hall.Seats;
            for (int i = 1, column = 0, row = 0; i <= seats.Count; i++, column++)
            {

                if (column % 10 == 0)
                {
                    hallView.Rows.Add(new DataGridViewRow());
                    if (column != 0) row++;
                    column = 0;
                }

                if (!seats[i - 1].IsFree)
                {
                    hallView.Rows[row].Cells[column].Style.BackColor = Color.Gray;
                    hallView.Rows[row].Cells[column].Style.SelectionBackColor = Color.Gray;
                }
                else
                {
                    hallView.Rows[row].Cells[column].Style.BackColor = seats[i - 1].GetSeatColour();
                }
                hallView[column, row].Value = i;
            }
            EnableBuyButton();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            EnableBuyButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyWindow buyForm = new BuyWindow(_ticket, _movie.Seances[seanceListBox.SelectedIndex].Hall.Seats[(int)hallView.SelectedCells[0].Value - 1]);
            Close();
            buyForm.ShowDialog();
        }
    }
}
