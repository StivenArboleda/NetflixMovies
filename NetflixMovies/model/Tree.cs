using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.model
{
    class Tree
    {
        private List<Movies> trueRow;
        private List<Movies> falseRow;

        public List<Movies>[] partition(List<Movies> movs, Question q)
        {
            List<Movies> trueRowPartition = new List<Movies>();
            List<Movies> falseRowPartition = new List<Movies>();
            foreach (Movies mov in movs)
            {
                if (q.match(mov))
                {
                    trueRowPartition.Add(mov);
                }
                else
                {
                    falseRowPartition.Add(mov);
                }
            }
            //trueRow = trueRowPartition;
            //falseRow = falseRowPartition;
            List<Movies>[] rows = new List<Movies>[2];
            rows[0] = trueRowPartition;
            rows[1] = falseRowPartition;
            return rows;
        }

        public double gini (List<Movies> movs)
        {
            Dictionary<String, int> counts = classCounts(movs);
            double impurity = 1.0;

            foreach (KeyValuePair<string, int> genres in counts) 
            {
                double prob = genres.Value / counts.Count;
                impurity -= Math.Pow(prob, 2);
            }
            return impurity;

        }

        public double infoGain(List<Movies> trueRow, List<Movies> falseRow, double currentUncertainty)
        {
            double p = (trueRow.Count / (trueRow.Count + falseRow.Count));
            return currentUncertainty - p * gini(trueRow) - (1 - p) * gini(falseRow);
        }

        public Dictionary<String, int> classCounts(List<Movies> movs)
        {
            Dictionary<string, int> genres = new Dictionary<string, int>();

            foreach (Movies m in movs)
            {
                if (genres.ContainsKey(m.Clasification))
                {
                    genres[m.Clasification] += 1;
                }
                else
                {
                    genres.Add(m.Clasification, 1);
                }
            }
            return genres;
        }

        public Split findBestSplit (List<Movies> movs)
        {
            double bestGain = 0.0;
            Question bestQuestion = null;
            double currentUncertainty = gini(movs);
            for(int i = 1; i < 7; i++)
            {
                HashSet<string> values = new HashSet<string>();
                foreach(Movies mov in movs)
                {
                    values.Add(mov.getByNumber(i));
                }

                HashSet<string>.Enumerator em = values.GetEnumerator();
                while (em.MoveNext())
                {
                    Question q = new Question(i, em.Current);
                    List<Movies>[] rows = partition(movs, q);
                    List<Movies> trueRow = rows[0];
                    List<Movies> falseRow = rows[1];
                    if(!(trueRow.Count == 0 || falseRow.Count == 0))
                    {
                        double gain = infoGain(trueRow, falseRow, currentUncertainty);
                        if (gain >= bestGain)
                        {
                            bestGain = gain;
                            bestQuestion = q;
                        }
                    }
                }
            }
            return new Split(bestGain, bestQuestion);
        }

        public Node buildTree (List<Movies> movs)
        {
            Split spl = findBestSplit(movs);
            if(spl.gainSetGet == 0)
            {
                return new Leaf(movs, null, null, null);
            }
            List<Movies>[] rows = partition(movs, spl.questionSetGet);
            Node trueBranch = buildTree(rows[0]);
            Node falseBranch = buildTree(rows[1]);
            return new Node(spl.questionSetGet, trueBranch, falseBranch);
        }

        public Dictionary<string, int> clasify(Movies movs, Node node)
        {
            if (node.GetType() == typeof(Leaf))
            {
                Leaf l = (Leaf)node;
                return l.predictions;
            }
            if (node.question.match(movs))
            {
                return clasify(movs, node.trueB);
            }
            else
            {
                return clasify(movs, node.falseB);
            }
        }
    }
}

        
       
      
