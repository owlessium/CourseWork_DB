using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Movies movies = new Movies();
            this.Hide();
            movies.ShowDialog();
            this.Show();
        }

        private void btnCritics_Click(object sender, EventArgs e)
        {
            FilmCritics filmCritics = new FilmCritics();
            this.Hide();
            filmCritics.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            this.Hide();
            users.ShowDialog();
            this.Show();
        }
    }
}
