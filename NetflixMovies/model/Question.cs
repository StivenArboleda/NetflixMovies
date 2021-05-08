using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.model
{
    class Question
    {
        private int columnNumber;
        private string value;
        private int intValue;

        public Question (int columnNumber, string value)
        {
            this.columnNumber = columnNumber;
            this.value = value;
            bool success = Int32.TryParse(value, out intValue);
            
        }

        public Boolean match (Movies m)
        {
            string val = m.getByNumber(columnNumber);

            int number;

            bool success = Int32.TryParse(val, out number);
            if (success)
            {
                return number >= intValue;
            }
            else
            {
                return val.Equals(value);
            }

        }

    }
}
