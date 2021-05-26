using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies.model
{
    class Tree
    {
        public Dictionary<string, double> giniTree(List<Movies> movies, string clasification, string actor, int year)
        {
            Dictionary<string, double> Tree = new Dictionary<string, double>();

            Tree.Add("clasification", giniClasification(movies, clasification));
            Tree.Add("cast", giniCast(movies, actor));
            Tree.Add("year", giniYear(movies, year));

            return Tree.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        }

        public Dictionary<int, string> buildTree(List<Movies> movies, Dictionary<string, double> gini, string clasification, string actor, int year)
        {
            int i = 0;
            Dictionary<int, string> Tree = gini.OrderByDescending(x => x.Value).ToDictionary(x => i++, x => x.Key);
            List<Movies> Nodo1 = new List<Movies>();
            List<Movies> Nodo2 = new List<Movies>();
            Dictionary<int, string> peli = new Dictionary<int, string>();
            int j = 0;
            string value;
            bool hasValue = Tree.TryGetValue(1, out value);
            if (value == "clasification")
            {
                foreach (Movies movie in movies)
                {
                    if (movie.Clasification.Contains(clasification))
                    {
                        Nodo1.Add(movie);
                    }
                }

                hasValue = Tree.TryGetValue(2, out value);
                if (value == "year")
                {
                    foreach (Movies dato1 in Nodo1)
                    {
                        if (dato1.ReleaseYear == year)
                        {
                            Nodo2.Add(dato1);
                        }
                    }

                    foreach (Movies dato2 in Nodo2)
                    {
                        if (dato2.Cast.Contains(actor))
                        {
                            peli.Add(j, dato2.Title);
                            j++;
                        }
                    }
                }
                else
                {
                    foreach (Movies dato1 in Nodo1)
                    {
                        if (dato1.Cast.Contains(actor))
                        {
                            peli.Add(j, dato1.Title);
                            j++;
                        }
                    }
                }
            }

            if (value == "year")
            {
                foreach (Movies movie in movies)
                {
                    if (movie.ReleaseYear == year)
                    {
                        Nodo1.Add(movie);
                    }
                }

                hasValue = Tree.TryGetValue(2, out value);
                if (value == "clasification")
                {
                    foreach (Movies dato1 in Nodo1)
                    {
                        if (dato1.Clasification.Contains(clasification))
                        {
                            Nodo2.Add(dato1);
                        }
                    }

                    foreach (Movies dato2 in Nodo2)
                    {
                        if (dato2.Cast.Contains(actor))
                        {
                            peli.Add(j, dato2.Title);
                            j++;
                        }
                    }
                }
                else
                {
                    foreach (Movies dato1 in Nodo1)
                    {
                        if (dato1.Cast.Contains(actor))
                        {
                            peli.Add(j, dato1.Title);
                            j++;
                        }
                    }
                }
            }


            if (value == "cast")
            {
                foreach (Movies movie in movies)
                {
                    if (movie.Cast.Contains(actor))
                    {
                        peli.Add(j, movie.Title);
                        j++;
                    }
                }
            }
            return Tree;
        }

        public Dictionary<int, string> listClasification(List<Movies> movies)
        {
            Dictionary<int, string> genders = new Dictionary<int, string>();
            int i = 0;

            foreach (Movies movie in movies)
            {
                string cadena = movie.Clasification;
                int start = 0;
                int end = cadena.Length; ;
                int inMoment = 0;
                int count = 0;
                bool similar = false;
                while (count <= end)
                {
                    inMoment = cadena.IndexOf(", ", start);

                    if (inMoment == -1)
                    {
                        foreach (string clasification in genders.Values)
                        {
                            if (clasification == cadena.Substring(start, end - start))
                            {
                                similar = true;
                            }
                        }

                        if (similar == false)
                        {
                            genders.Add(i, cadena.Substring(start, end - start));
                            i++;
                        }

                        break;
                    }

                    foreach (string clasification in genders.Values)
                    {
                        if (clasification == cadena.Substring(start, inMoment - start))
                        {
                            similar = true;
                        }
                    }

                    if (similar == false)
                    {
                        genders.Add(i, cadena.Substring(start, inMoment - start));
                        i++;
                    }
                    count += inMoment;
                    start = inMoment + 2;
                }
            }
            int j = 0;
            return genders.OrderBy(x => x.Value).ToDictionary(x => j++, x => x.Value);
        }

        public Dictionary<int, string> listCast(List<Movies> movies)
        {
            Dictionary<int, string> actors = new Dictionary<int, string>();
            int i = 0;

            foreach (Movies movie in movies)
            {
                string cadena = movie.Cast;
                int start = 0;
                int end = cadena.Length; ;
                int inMoment = 0;
                int count = 0;
                bool similar = false;
                while (count <= end)
                {
                    inMoment = cadena.IndexOf(", ", start);

                    if (inMoment == -1)
                    {
                        foreach (string clasification in actors.Values)
                        {
                            if (clasification == cadena.Substring(start, end - start))
                            {
                                similar = true;
                            }
                        }

                        if (similar == false)
                        {
                            actors.Add(i, cadena.Substring(start, end - start));
                            i++;
                        }

                        break;
                    }

                    foreach (string clasification in actors.Values)
                    {
                        if (clasification == cadena.Substring(start, inMoment - start))
                        {
                            similar = true;
                        }
                    }

                    if (similar == false)
                    {
                        actors.Add(i, cadena.Substring(start, inMoment - start));
                        i++;
                    }
                    count += inMoment;
                    start = inMoment + 2;
                }
            }
            int j = 0;
            return actors.OrderBy(x => x.Value).ToDictionary(x => j++, x => x.Value);
        }

        public Dictionary<int, int> listYear(List<Movies> movies)
        {
            Dictionary<int, int> years = new Dictionary<int, int>();
            int i = 0;
            foreach (Movies movie in movies)
            {
                int dato = movie.ReleaseYear;
                bool similar = false;
                foreach (int year in years.Values)
                {
                    if (year == movie.ReleaseYear)
                    {
                        similar = true;
                    }
                }

                if (similar == false)
                {
                    years.Add(i, movie.ReleaseYear);
                    i++;
                }
            }
            int j = 0;
            return years.OrderBy(x => x.Value).ToDictionary(x => j++, x => x.Value);
        }


        public double giniClasification(List<Movies> movies, string clasification)
        {
            double x = 0;
            double y = 0;
            double n = 0;
            double impurity = 0;

            foreach (Movies movie in movies)
            {
                if (movie.Clasification.Contains(clasification))
                {
                    x += 1;
                    n += 1;
                }
                else
                {
                    y += 1;
                    n += 1;
                }
            }

            impurity = 1 - Math.Pow((x / n), 2) - Math.Pow((y / n), 2);
            return impurity;

        }


        public double giniCast(List<Movies> movies, string cast)
        {
            double x = 0;
            double y = 0;
            double n = 0;
            double impurity = 0;

            foreach (Movies movie in movies)
            {
                if (movie.Cast.Contains(cast))
                {
                    x += 1;
                    n += 1;
                }
                else
                {
                    y += 1;
                    n += 1;
                }
            }

            impurity = 1 - Math.Pow((x / n), 2) - Math.Pow((y / n), 2);
            return impurity;

        }

        public double giniYear(List<Movies> movies, int year)
        {
            double x = 0;
            double y = 0;
            double n = 0;
            double impurity;

            foreach (Movies movie in movies)
            {
                if (movie.ReleaseYear == year)
                {
                    x += 1;
                    n += 1;
                }
                else
                {
                    y += 1;
                    n += 1;
                }
            }

            impurity = 1 - Math.Pow((x / n), 2) - Math.Pow((y / n), 2);
            return impurity;
        }
    }
}

        
       
      
