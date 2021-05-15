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
        public PrincipalPane()
        {
            InitializeComponent();
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
            openChildForm(new TreeForm())
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
