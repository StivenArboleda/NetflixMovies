using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetflixMovies.model;

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
            Console.WriteLine("hola");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());

            Data d = new Data();
            d.loadData();


            // llenamos
            List<Movies> complete = d.list;

            // pasmo como vecto  con Tree.cs
            Movies[] training = new Movies[1040];
            Array.Copy(complete.ToArray(), training, 1040);

            Question questionTree = new Question(10,"Titulo pelicula");

            Tree treeObcject = new Tree();
            treeObcject.partition(complete, questionTree);

            //Dictionary gener  = new Dictionary; 

            treeObcject.classCounts(complete);



            Movies[] testing = new Movies[4337];
            Array.Copy(complete.ToArray(), testing, 4337);
        }
    }
}