using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.model
{
    public class Split
    {
        private double gain;
        private Question question;

        public Split (double gain, Question question)
        {
            this.gain = gain;
            this.question = question;
        }

        public double gainSetGet { get => gain; set => gain = value; }
        public Question questionSetGet { get => question; set => question = value; }
    }
}
