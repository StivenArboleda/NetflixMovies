using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixMovies.ui

{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrincipalPane());
            Data d = new Data();
            d.loadData();
            List<Movies> complete = d.list;
            Movies[] training = new Movies[1040];
            Array.Copy(complete.ToArray(), training, 1040);
            Movies[] testing = new Movies[4337];
            Array.Copy(complete.ToArray(), testing, 4337);
        }
    }
}