using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.model
{
    class TreeC
    {

        public Dictionary<int, string> classCounts(List<Movies> movs)
        {
            Dictionary<string, int> genres = new Dictionary<string, int>();

            Dictionary<int, string> generos = new Dictionary<int, string>();

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


            int i = 0;

            foreach (string clasificacion in genres.Keys)
            {
                string cadena = clasificacion;
                int end = cadena.Length;
                int start = 0;
                int count = 0;
                int at = 0;
                bool similar = false;

                while (count <= end)
                {

                    at = cadena.IndexOf(", ", start);
                    if (at == -1)
                    {
                        foreach (string dato in generos.Values)
                        {
                            if (dato == cadena.Substring(start, end - start))
                            {
                                similar = true;
                            }
                        }

                        if (similar == false)
                        {
                            generos.Add(i, cadena.Substring(start, end - start));
                            i++;
                        }
                        break;
                    }

                    foreach (string dato in generos.Values)
                    {
                        if (dato == cadena.Substring(start, at - start))
                        {
                            similar = true;
                        }
                    }

                    if (similar == false)
                    {
                        generos.Add(i, cadena.Substring(start, at - start));
                        i++;
                    }
                    count += at;
                    start = at + 2;

                }
            }

            return generos;

        } // classCounts


        public Dictionary<int, string> castCounts(List<Movies> movs)
        {
            Dictionary<string, int> actors = new Dictionary<string, int>();

            Dictionary<int, string> actores = new Dictionary<int, string>();

            foreach (Movies m in movs)
            {
                if (actors.ContainsKey(m.Cast))
                {
                    actors[m.Cast] += 1;
                }
                else
                {
                    actors.Add(m.Cast, 1);
                }
            }


            int i = 0;

            foreach (string cast in actors.Keys)
            {
                string cadena = cast;
                int end = cadena.Length;
                int start = 0;
                int count = 0;
                int at = 0;
                bool similar = false;

                while (count <= end)
                {

                    at = cadena.IndexOf(", ", start);
                    if (at == -1)
                    {
                        foreach (string dato in actores.Values)
                        {
                            if (dato == cadena.Substring(start, end - start))
                            {
                                similar = true;
                            }
                        }

                        if (similar == false)
                        {
                            actores.Add(i, cadena.Substring(start, end - start));
                            i++;
                        }
                        break;
                    }

                    foreach (string dato in actores.Values)
                    {
                        if (dato == cadena.Substring(start, at - start))
                        {
                            similar = true;
                        }
                    }

                    if (similar == false)
                    {
                        actores.Add(i, cadena.Substring(start, at - start));
                        i++;
                    }
                    count += at;
                    start = at + 2;

                }
            }

            return actores;

        }

        public Dictionary<int, int> yearCounts(List<Movies> movs)
        {
            Dictionary<int, int> years = new Dictionary<int, int>();
            int i = 0;
            
            foreach (Movies m in movs)
            {
                bool similar = false;
                foreach (int dato in years.Values)
                {
                    if (dato == m.ReleaseYear)
                    {
                        similar = true;
                    }
                }

                if (similar == false)
                {
                    years.Add(i, m.ReleaseYear);
                    i++;
                }

            }

            return years;
        } // yearCount


        public double gini(List<Movies> movs, string PalabraBuscar, string variable)
        {
            //Gini = 1 + (x/n)^2 - (y/n)^2
            // x son respuestas ( si o correctas)
            // y son respúestas negativas ( no encotrado)
            // n  total de muestras

            int contadorX = 0; //1
            int contadorY = 0; //0
            int totalMuestas = 0; //1
            double gini = 1;
            
            foreach (Movies dato in movs)
            {
                bool condicion;
                switch (variable)
                {
                    case "year":
                        int valor = Int32.Parse(PalabraBuscar);
                        if (dato.ReleaseYear.CompareTo(valor) == 0)
                        {
                            condicion = true;
                        }
                        else {
                            condicion = false;
                        }
                        break;
                    case "Cast"  :
                        condicion = dato.Cast.Contains(PalabraBuscar);
                        break;
                    default:
                        condicion = dato.Clasification.Contains(PalabraBuscar);
                        break;
                }

                if (condicion == true)
                {
                    contadorX++;
                    totalMuestas++;
                }
                else {
                    contadorY++;
                    totalMuestas++;
                }
               gini += Math.Pow(contadorX, 2) - Math.Pow(contadorY, 2);
            }
            return gini;

        } // gini

    //   if  gini(List, "Dramas", "Clasification" )>= 0.5

      //      gini(List, 2008, year )

        //    gini(List, "Robin William", "cast")


    } //TreeC
} // namespace
