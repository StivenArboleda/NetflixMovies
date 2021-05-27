using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace NetflixMovies.model
{
    class TreeML
    {
        [LoadColumn(10)]
        public string Clasification { get; set; }

        [LoadColumn(7)]
        public string ReleaseYear { get; set; }

        [LoadColumn(4)]
        public string Cast { get; set; }
    }
}
