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
    public partial class MainMoviesWindow : Form
    {

        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public MainMoviesWindow()
        {
            InitializeComponent();
            Cinema.DeserializeJSON();
            cinemaNameLabel.Text = Cinema.GetCinema().Name;
            SetMovies();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow row = moviesView.SelectedRows[0];
            HallWindow hallWind = new HallWindow(row.Index);
            hallWind.ShowDialog();
            SetMovies();
        }

        private void SetMovies()
        {
            moviesView.Rows.Clear();
            List<Movie> movies = Cinema.GetCinema().Movies;
            for (int i = 0; i < movies.Count; i++)
            {
                int minCost = movies[i].GetPrice();
                string extraInfo = "";

                if (movies[i].Type == FilmType.Premiere)
                {
                    PremiereMarkup pm = new PremiereMarkup(movies[i]);
                    extraInfo = pm.GetExtraInfo();
                    minCost = pm.GetPrice();
                }
                else if (movies[i].Type == FilmType.StudentSale)
                {
                    StudentSale ss = new StudentSale(movies[i]);
                    extraInfo = ss.GetExtraInfo();
                }
                moviesView.Rows.Add(
                    resizeImage(movies[i].GetImage(), new Size(100, 100)),
                    movies[i].Name + Environment.NewLine + movies[i].Genre + Environment.NewLine + movies[i].MinAge + "+"
                    + Environment.NewLine + "(from " + minCost + " hrn)",
                    extraInfo);
                moviesView.Rows[i].Tag = movies[i];
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            EnterCinema entWind = new EnterCinema(false);
            entWind.ShowDialog();
            if (Cinema.CurUser == null)
            {
                enterButton.Visible = true;
                registerButton.Visible = true;
                profileButton.Visible = false;
                exitButton.Visible = false;
            }
            else
            {
                enterButton.Visible = false;
                registerButton.Visible = false;
                profileButton.Visible = true;
                exitButton.Visible = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            EnterCinema entWind = new EnterCinema(true);
            entWind.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Cinema.ExitCinema();
            enterButton.Visible = true;
            registerButton.Visible = true;
            profileButton.Visible = false;
            exitButton.Visible = false;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile();
            profile.ShowDialog();
        }

        private void MainMoviesWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cinema.SerializeJSON();
        }
    }
}
