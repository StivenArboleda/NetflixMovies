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

        public void partition(List<Movies> movs, Question q)
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
            trueRow = trueRowPartition;
            falseRow = falseRowPartition;
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
    }
}

        
       
      
