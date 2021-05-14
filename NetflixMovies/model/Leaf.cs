using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.model
{
    class Leaf: Node

    {
        private Dictionary<string, int> occurrences;
        public Leaf(List<Movies> movs, Question q, Node trueBranch, Node falseBranch) : base (q, trueBranch, falseBranch)
        {
            occurrences = classCounts(movs);
        }
        public Dictionary <String, int> classCounts(List<Movies> movs)
        {
            Dictionary<string, int> genres = new Dictionary<string, int>();

            foreach (Movies m in movs)
            {
                if (genres.ContainsKey(m.Clasification)){
                    genres[m.Clasification] += 1;
                }
                else
                {
                    genres.Add(m.Clasification, 1);
                }
            }
            return genres;
        }
        public Dictionary<string, int> predictions { get => occurrences; set => occurrences = value; }
    }
}
