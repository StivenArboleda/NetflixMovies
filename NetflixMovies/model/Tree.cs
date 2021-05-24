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
            Dictionary<int, String> counts = classCounts(movs);
            double impurity = 1.0;

            foreach (KeyValuePair<int,string> genres in counts) 
            {
                double prob = genres.Key / counts.Count;
                impurity -= Math.Pow(prob, 2);
            }
            return impurity;

        }

        public double infoGain(List<Movies> trueRow, List<Movies> falseRow, double currentUncertainty)
        {
            double p = (trueRow.Count / (trueRow.Count + falseRow.Count));
            return currentUncertainty - p * gini(trueRow) - (1 - p) * gini(falseRow);
        }

        // isa
        public Dictionary<int, string> classCounts(List<Movies> movs)
        {
            Dictionary<string, int> genres = new Dictionary<string, int>();

            Dictionary<int, string> generos = new Dictionary<int, string>();

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

            Console.WriteLine(genres);

            int i = 0;

            foreach (string clasificacion in genres.Keys)
            {
                string cadena = clasificacion;
                int end = cadena.Length;
                int start = 0;
                int count = 0;
                int at = 0;
                bool similar = false;

                while (count <= end)
                {

                    at = cadena.IndexOf(", ", start);
                    if (at == -1)
                    {
                        foreach (string dato in generos.Values)
                        {
                            if (dato == cadena.Substring(start, end - start))
                            {
                                similar = true;
                            }
                        }

                        if (similar == false)
                        {
                            generos.Add(i, cadena.Substring(start, end - start));
                            i++; 
                        }
                        break;
                    }

                    foreach (string dato in generos.Values) { 
                        if (dato == cadena.Substring(start, at - start))
                        {
                            similar = true;
                        }
                    }   

                    if (similar == false)
                    {
                        generos.Add(i, cadena.Substring(start, at - start));
                        i++;
                    }
                    count += at;
                    start = at + 2;
                                   
                }
            }

            return generos;

        }
        // isa


        // isa

        public Dictionary<int, string> castCounts(List<Movies> movs)
        {
            Dictionary<string, int> actors = new Dictionary<string, int>();

            Dictionary<int, string> actores = new Dictionary<int, string>();

            foreach (Movies m in movs)
            {
                if (actors.ContainsKey(m.Cast))
                {
                    actors[m.Cast] += 1;
                }
                else
                {
                    actors.Add(m.Cast, 1);
                }
            }


            int i = 0;

            foreach (string cast in actors.Keys)
            {
                string cadena = cast;
                int end = cadena.Length;
                int start = 0;
                int count = 0;
                int at = 0;
                bool similar = false;

                while (count <= end)
                {

                    at = cadena.IndexOf(", ", start);
                    if (at == -1)
                    {
                        foreach (string dato in actores.Values)
                        {
                            if (dato == cadena.Substring(start, end - start))
                            {
                                similar = true;
                            }
                        }

                        if (similar == false)
                        {
                            actores.Add(i, cadena.Substring(start, end - start));
                            i++;
                        }
                        break;
                    }

                    foreach (string dato in actores.Values)
                    {
                        if (dato == cadena.Substring(start, at - start))
                        {
                            similar = true;
                        }
                    }

                    if (similar == false)
                    {
                        actores.Add(i, cadena.Substring(start, at - start));
                        i++;
                    }
                    count += at;
                    start = at + 2;

                }
            }

            return actores;

        }


        // isa







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

        
       
      
