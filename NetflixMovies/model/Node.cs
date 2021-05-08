using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.model
{
    class Node
    {
        private Question q;
        private Movies trueBranch;
        private Movies falseBranch;

        public Node(Question q, Movies trueBranch, Movies falseBranch)
        {
            this.q = q;
            this.trueBranch = trueBranch;
            this.falseBranch = falseBranch;
        }
    }
}


