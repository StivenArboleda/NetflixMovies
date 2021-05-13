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
        private Node trueBranch;
        private Node falseBranch;

        public Node(Question q, Node trueBranch, Node falseBranch)
        {
            this.q = q;
            this.trueBranch = trueBranch;
            this.falseBranch = falseBranch;
        }

        public Question question { get => q; set => q = value; }
        public Node trueB { get => trueBranch; set => trueBranch = value; }
        public Node falseB { get => falseBranch; set => falseBranch = value; }
    }
}


