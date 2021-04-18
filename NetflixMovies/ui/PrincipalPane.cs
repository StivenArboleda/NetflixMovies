using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixMovies.ui
{
    public partial class PrincipalPane : Form
    {
        OpenFileDialog actual;
        Control c;
        string searchCriteria;

        public PrincipalPane()
        {
            InitializeComponent();
            actual = new OpenFileDialog();
            c = new Control();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actual.Filter = "CSV|*.csv";
            List<Movies> movie = new List<Movies>();
            if (actual.ShowDialog() == DialogResult.OK)
            {
                string path = actual.FileName;
                MessageBox.Show("Data uploaded correctly.");
                movie = c.load(path);
                load(movie);
            }
        }

        private void load(List<Movies> movie)
        {
            dataGridView2.DataSource = movie;
            Dictionary<int, int> dict = c.dat.MoviesPerYear();
            var movies = chart1.Series.Add("Movies");
            foreach(KeyValuePair<int,int> d in dict)
            {
                movies.Points.AddXY(d.Key, d.Value);
            }
            Dictionary<string, int> dict2 = c.dat.MoviesByDuration();
            var movies2 = chart2.Series.Add("Movies");
            foreach (KeyValuePair<string, int> d in dict2)
            {
                movies2.Points.AddXY(d.Key, d.Value);
            }
        }

        private void PrincipalPane_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text.ToString();
            List<Movies> m = new List<Movies>();
            switch (searchCriteria)
            {
                case "movieId":
                    m = c.dat.IdMovieList(name);
                    break;
                case "title":
                    m = c.dat.TitleMovieList(name);
                    break;
                case "director":
                    m = c.dat.DirectorMovieList(name);
                    break;
                case "cast":
                    m = c.dat.CastMovieList(name);
                    break;
                case "countryOfOrigin":
                    m = c.dat.ContryOfOriginMovieList(name);
                    break;
                case "datePublishedNet":
                    m = c.dat.PublishedDateMovieList(name);
                    break;
                case "releaseYear":
                    int releaseYear = Int32.Parse(name);
                    m = c.dat.ReleaseYearMovieList(releaseYear);
                    break;
                case "minutesOfMovie":
                    int minutesOfMovie = Int32.Parse(name); ;
                    m = c.dat.ReleaseYearMovieList(minutesOfMovie);
                    break;
                case "clasification":
                    string clas = comboBox2.Text;
                    m = c.dat.ClasificationMovieList(clas);
                    break;
                default:
                    break;
            }
            dataGridView2.DataSource = m;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchCriteria = comboBox1.Text;
            if(comboBox1.Text == "clasification")
            {
                comboBox2.Visible = true;
            }
            else
            {
                comboBox2.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
