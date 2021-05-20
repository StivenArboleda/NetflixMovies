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
    public partial class TreeForm : Form
    {
        public TreeForm()
        {
            InitializeComponent();
            treeView1.Nodes.Add("Peliculas");
        }

        private void Show_Click(object sender, EventArgs e)
        {
            
            treeView1.SelectedNode.Nodes.Add("genero");
            treeView1.SelectedNode.Nodes.Add("Año");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("drama");
            treeView1.Nodes[0].Nodes[1].Nodes.Add("comedia");

            treeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add("Año");

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
