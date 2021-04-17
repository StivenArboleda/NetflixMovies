using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.ui
{
    class Control
    {
        Data d;
        internal List<Movies> load(string path)
        {
            d.loadData();
            return d.movie;
        }

        public Control()
        {
            d = new Data();
        }
    }
}
