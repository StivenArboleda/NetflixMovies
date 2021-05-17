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

    public partial class GraphForm : Form
    {
        OpenFileDialog actual;
        Control c;
        GridForm grid;
        public GraphForm()
        {
            InitializeComponent();
            actual = new OpenFileDialog();
            c = new Control();
        }

        private void load(List<Movies> movie)
        {
            Dictionary<int, int> dict = c.dat.MoviesPerYear();
            var movies = chart1.Series.Add("Movies");
            foreach (KeyValuePair<int, int> d in dict)
            {
                movies.Points.AddXY(d.Key, d.Value);
            }
            Dictionary<string, int> dict2 = c.dat.MoviesByDuration();
            var movies2 = chart2.Series.Add("Movies");
            foreach (KeyValuePair<string, int> d in dict2)
            {
                movies2.Points.AddXY(d.Key, d.Value);
            }
            Dictionary<string, int> dict3 = c.dat.MoviesByGenre();
            chart3.ChartAreas[0].AxisX.Title = "genre";
            foreach (KeyValuePair<string, int> d in dict3)
            {
                var movies3 = chart3.Series.Add(d.Key);
                movies3.Points.AddXY(d.Key, d.Value);
            }
            Dictionary<string, int> dict4 = c.dat.MoviesByDirector();
            chart4.ChartAreas[0].AxisX.Title = "director";
            foreach (KeyValuePair<string, int> d in dict4)
            {
                var movies4 = chart4.Series.Add(d.Key);
                movies4.Points.AddXY(d.Key, d.Value);
            }
            Dictionary<string, int> dict5 = c.dat.MoviesByCountry();
            chart5.ChartAreas[0].AxisX.Title = "Country";
            foreach (KeyValuePair<string, int> d in dict5)
            {
                var movies5 = chart5.Series.Add(d.Key);
                movies5.Points.AddXY(d.Key, d.Value);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}
