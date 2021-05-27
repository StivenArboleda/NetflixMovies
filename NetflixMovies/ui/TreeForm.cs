using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetflixMovies.model;

namespace NetflixMovies.ui
{
    public partial class TreeForm : Form
    {

        Tree arbol = new Tree();
        List<Movies> movie = new List<Movies>();
        Control c = new Control();

        public TreeForm()
        {
            InitializeComponent();

            string path = "..\\..\\Data\\netflix_titles.csv";
            movie = c.load(path);

            Dictionary<int, string> clasification = arbol.listClasification(movie);
            Dictionary<int, string> cast = arbol.listCast(movie);
            Dictionary<int, int> year = arbol.listYear(movie);

            comboGender.DataSource = new BindingSource(clasification, null);
            comboGender.DisplayMember = "Value";
            comboGender.ValueMember = "Key";

            comboCast.DataSource = new BindingSource(cast, null);
            comboCast.DisplayMember = "Value";
            comboCast.ValueMember = "Key";

            comboYear.DataSource = new BindingSource(year, null);
            comboYear.DisplayMember = "Value";
            comboYear.ValueMember = "Key";
        }

        private void Show_Click(object sender, EventArgs e)
        {

            string gender;
            string actor;
            int year;

            gender = comboGender.Text;
            actor = comboCast.Text;
            year = Int32.Parse(comboYear.Text); 

            if (Implementation.Checked == true)
            {
               
                Dictionary<string, double> giniTree = arbol.giniTree(movie, gender, actor, year);
                Dictionary<int, string> buildTree = arbol.buildTree(movie, giniTree, gender, actor, year);

                foreach (string nodo in giniTree.Keys) {
                    TreeNode newNode = new TreeNode(nodo);
                    treeView1.Nodes.Add(newNode);
                }

                foreach (string child in buildTree.Values)
                {
                    
                    treeView1.Nodes[2].Nodes.Add(child);
                }
            }

            if (library.Checked == true)
            {

               

            }
        }

        private void load(List<Movies> movie)
        {
            throw new NotImplementedException();
        }
    }
 }
