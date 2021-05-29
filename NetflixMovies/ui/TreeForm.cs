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
using NetflixMoviesML.Model;

namespace NetflixMovies.ui
{
    public partial class TreeForm : Form
    {

        ClassTree arbol = new ClassTree();
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

            treeView1.Nodes.Clear();
            string gender;
            string actor;
            string year;

            gender = comboGender.Text;
            actor = comboCast.Text;
            year = "1900";
            if (comboYear.Text != "")
            {
                year = comboYear.Text;
            }


            if (Implementation.Checked == true)
            {

                Dictionary<string, double> giniTree = arbol.giniTree(movie, gender, actor, year);
                List<Movies>[] buildTree = new List<Movies>[3];

                buildTree[0] = arbol.buildTree(movie, giniTree, gender, actor, year)[0]; // raiz
                buildTree[1] = arbol.buildTree(movie, giniTree, gender, actor, year)[1]; // nodo1
                buildTree[2] = arbol.buildTree(movie, giniTree, gender, actor, year)[2]; // nodo 2

                foreach (string nodo in giniTree.Keys)
                {
                    TreeNode newNode = new TreeNode(nodo);
                    treeView1.Nodes.Add(newNode);
                }
                treeView1.Nodes.Add("movies");

                TreeNode[] nodeClasification = treeView1.Nodes
                              .Cast<TreeNode>()
                              .Where(r => r.Text == "clasification")
                              .ToArray();

                TreeNode[] nodeCast = treeView1.Nodes
                               .Cast<TreeNode>()
                               .Where(r => r.Text == "cast")
                               .ToArray();

                TreeNode[] nodeYear = treeView1.Nodes
                         .Cast<TreeNode>()
                         .Where(r => r.Text == "year")
                         .ToArray();

                Dictionary<string, int> partCast = arbol.countCast(buildTree[nodeCast[0].Index]);
                Dictionary<string, int> partClas = arbol.countClasification(buildTree[nodeClasification[0].Index]);
                Dictionary<string, int> partYear = arbol.countYear(buildTree[nodeYear[0].Index]);

                foreach (string raiz in partCast.Keys)
                {
                    nodeCast[0].Nodes.Add(raiz);
                }


                foreach (string raiz in partClas.Keys)
                {
                    nodeClasification[0].Nodes.Add(raiz);
                }

                foreach (string raiz in partYear.Keys)
                {
                    nodeYear[0].Nodes.Add(raiz);
                }


                if (buildTree[2] == null)
                {
                    foreach (Movies nodo1 in buildTree[1])
                    {
                        treeView1.Nodes[3].Nodes.Add(nodo1.Title);
                    }
                }
                else
                {
                    foreach (Movies nodo1 in buildTree[2])
                    {
                        treeView1.Nodes[3].Nodes.Add(nodo1.Title);
                    }
                }


                treeView1.EndUpdate();
            }
            if(library.Checked == true)
            {
                var str = comboGender.SelectedItem;

                ModelInput sampleData = new ModelInput()
                {
                    Listed_in = @""+str,
                };

                // Make a single prediction on the sample data and print results
                var predictionResult = ConsumeModel.Predict(sampleData);

                Console.WriteLine("Using model to make single prediction -- Comparing actual Type with predicted Type from sample data...\n\n");
                Console.WriteLine($"Listed_in: {sampleData.Listed_in}");
                Console.WriteLine($"\n\nPredicted Type value {predictionResult.Prediction} \nPredicted Type scores: [{String.Join(",", predictionResult.Score)}]\n\n");
                Console.WriteLine("=============== End of process, hit any key to finish ===============");
                Console.ReadKey();


            }

        }

        private void load(List<Movies> movie)
        {
            throw new NotImplementedException();
        }

        private void library_CheckedChanged(object sender, EventArgs e)
        {
            comboCast.Visible = false;
            comboYear.Visible = false;
        }

        private void Implementation_CheckedChanged(object sender, EventArgs e)
        {
            comboCast.Visible = true;
            comboYear.Visible = true;
        }
    }
}
