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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // openChildForm(new );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new GraphForm());
        }

        private void openChildForm(object child)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);

            Form childF = child as Form;
            childF.TopLevel = false;
            childF.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(childF);
            this.contenedor.Tag = childF;
            childF.Show();
        }
    }
}
