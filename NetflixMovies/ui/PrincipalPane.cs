using System;
using System.Windows.Forms;

namespace NetflixMovies.ui
{
    public partial class Principal : Form
    {

        GridForm grid;
        GraphForm graph;
        TreeForm t;

        public Principal()
        {
            InitializeComponent();
            grid = new GridForm();
            graph = new GraphForm();
            t = new TreeForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new GridForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new GraphForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new TreeForm());
        }

        private void openChildForm(object child)
        {
            if (this.container.Controls.Count > 0)
                this.container.Controls.RemoveAt(0);

            Form childF = child as Form;
            childF.TopLevel = false;
            childF.Dock = DockStyle.Fill;
            this.container.Controls.Add(childF);
            this.container.Tag = childF;
            childF.Show();
        }
    }
}
