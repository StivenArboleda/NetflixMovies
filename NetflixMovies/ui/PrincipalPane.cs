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
                MessageBox.Show("Datos cargados correctamente.");
                movie = c.load(path);
                load(movie);
            }
        }

        private void load(List<Movies> movie)
        {
            dataGridView2.DataSource = movie;
        }
    }
}
