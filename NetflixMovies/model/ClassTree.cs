using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NetflixMovies.model
{
    class ClassTree
    {
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

        public List<Movies>[] partitionClasification(List<Movies> movies, string Clasification)
        {
            List<Movies>[] partition = new List<Movies>[2];
            List<Movies> pure = new List<Movies>();
            List<Movies> blend = new List<Movies>();

            foreach (Movies movie in movies)
            {
                if (movie.Clasification.Equals(Clasification))
                {
                    pure.Add(movie); // 100%
                }
                if (movie.Clasification.Contains(Clasification))
                {
                    blend.Add(movie);
                }
            }

            partition[0] = pure;
            partition[1] = blend;

            return partition;
        }

        public List<Movies>[] partitionCast(List<Movies> movies, string cast)
        {
            List<Movies>[] partition = new List<Movies>[2];
            List<Movies> pure = new List<Movies>();
            List<Movies> blend = new List<Movies>();

            foreach (Movies movie in movies)
            {
                if (movie.Cast.Equals(cast))
                {
                    pure.Add(movie); // 100%
                }
                if (movie.Cast.Contains(cast))
                {
                    blend.Add(movie);
                }
            }

            partition[0] = pure;
            partition[1] = blend;

            return partition;
        }

        public List<Movies>[] partitionYear(List<Movies> movies, string Year)
        {
            List<Movies>[] partition = new List<Movies>[2];
            List<Movies> pure = new List<Movies>();
            List<Movies> blend = new List<Movies>();

            foreach (Movies movie in movies)
            {
                if (movie.ReleaseYear == Int32.Parse(Year))
                {
                    pure.Add(movie); // 100%
                }
                if (movie.ReleaseYear >= Int32.Parse(Year))
                {
                    blend.Add(movie);
                }
            }

            partition[0] = pure;
            partition[1] = blend;

            return partition;
        }

        public Dictionary<string, int> countClasification(List<Movies> movies)
        {
            Dictionary<int, string> Clasification = listClasification(movies);
            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (Movies movie in movies)
            {
                foreach (string x in Clasification.Values)
                {
                    if (movie.Clasification.Contains(x))
                    {
                        if (data.ContainsKey(x))
                        {
                            data[x] += 1;
                        }
                        else
                        {
                            data.Add(x, 1);
                        }
                    }
                }
            }
            return data.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public Dictionary<string, int> countCast(List<Movies> movies)
        {
            Dictionary<int, string> Cast = listCast(movies);
            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (Movies movie in movies)
            {
                foreach (string x in Cast.Values)
                {
                    if (movie.Cast.Contains(x))
                    {
                        if (data.ContainsKey(x))
                        {
                            data[x] += 1;
                        }

                        else
                        {
                            data.Add(x, 1);
                        }
                    }
                }
            }
            return data.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public Dictionary<string, int> countYear(List<Movies> movies)
        {
            Dictionary<int, int> Year = listYear(movies);
            Dictionary<string, int> data = new Dictionary<string, int>();

            foreach (Movies movie in movies)
            {
                foreach (int x in Year.Values)
                {
                    if (movie.ReleaseYear == x)
                    {
                        if (data.ContainsKey(Convert.ToString(x)))
                        {
                            data[Convert.ToString(x)] += 1;
                        }

                        else
                        {
                            data.Add(Convert.ToString(x), 1);
                        }
                    }
                }
            }
            return data.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public double[] giniPurity(List<Movies> movies, int node, string word)
        {

            List<Movies> partitionPure = new List<Movies>();
            List<Movies> partitionBlend = new List<Movies>();
            Dictionary<string, int> countDataPure = new Dictionary<string, int>();
            Dictionary<string, int> countDataBlend = new Dictionary<string, int>();

            switch (node)
            {
                case 1:
                    partitionPure = partitionClasification(movies, word)[0];
                    partitionBlend = partitionClasification(movies, word)[1];
                    countDataPure = countClasification(partitionPure);
                    countDataBlend = countClasification(partitionBlend);
                    break;
                case 2:
                    partitionPure = partitionCast(movies, word)[0];
                    partitionBlend = partitionCast(movies, word)[1];
                    countDataPure = countCast(partitionPure);
                    countDataBlend = countCast(partitionBlend);
                    break;

                case 3:
                    partitionPure = partitionYear(movies, word)[0];
                    partitionBlend = partitionYear(movies, word)[1];
                    countDataPure = countYear(partitionPure);
                    countDataBlend = countYear(partitionBlend);
                    break;

            }

            double[] impurity = new double[4];
            impurity[0] = countDataPure.Count;
            impurity[1] = countDataBlend.Count - countDataPure.Count;
            impurity[2] = (1 / impurity[1]) * 100;
            impurity[3] = Math.Pow(1 - (1 / Convert.ToDouble(countDataBlend.Count)), 2) * 100;
            return impurity;
        }
        public Dictionary<string, double> giniTree(List<Movies> movies, string clasification, string actor, string year) // variable objetivo es el actor
        {
            Dictionary<string, double> Tree = new Dictionary<string, double>();
            Tree.Add("clasification", giniPurity(movies, 1, clasification)[3]);
            Tree.Add("cast", giniPurity(movies, 2, actor)[3]);
            Tree.Add("year", giniPurity(movies, 3, year)[3]);

            return Tree.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
        }

        public List<Movies>[] buildTree(List<Movies> movies, Dictionary<string, double> gini, string clasification, string actor, string year)
        {
            int i = 0;
            Dictionary<int, string> Tree = gini.OrderByDescending(x => x.Value).ToDictionary(x => i++, x => x.Key);

            List<Movies>[] peli = new List<Movies>[3];

            string value1, value2, value3;
            bool hasValue1 = Tree.TryGetValue(0, out value1);
            bool hasValue2 = Tree.TryGetValue(1, out value2);
            bool hasValue3 = Tree.TryGetValue(2, out value3);

            if (value1 == "cast" && value2 == "clasification" && value3 == "year")
            {
                for (int j = 0; j < 2; j++)
                {
                    if (partitionCast(movies, actor)[j].Count >= 1)
                    {
                        peli[0] = partitionCast(movies, actor)[j];

                        if (partitionClasification(peli[0], clasification)[j].Count >= 1)
                        {
                            peli[1] = partitionClasification(peli[0], clasification)[j];

                            if (partitionYear(peli[1], year)[j].Count >= 1)
                            {
                                peli[2] = partitionClasification(peli[1], clasification)[j];
                            }
                        }
                    }
                }
            }


            if (value1 == "cast" && value2 == "year" && value3 == "clasification")
            {
                for (int j = 0; j < 2; j++)
                {
                    if (partitionCast(movies, actor)[j].Count >= 1)
                    {
                        peli[0] = partitionCast(movies, actor)[j];

                        if (partitionYear(peli[0], year)[j].Count >= 1)
                        {
                            peli[1] = partitionYear(peli[0], year)[j];

                            if (partitionClasification(peli[1], clasification)[j].Count >= 1)
                            {
                                peli[2] = partitionClasification(peli[1], clasification)[j];
                            }
                        }
                    }
                }
            }


            if (value1 == "year" && value2 == "cast" && value3 == "clasification")
            {
                for (int j = 0; j < 2; j++)
                {
                    if (partitionYear(movies, year)[j].Count >= 1)
                    {
                        peli[0] = partitionYear(movies, year)[j];

                        if (partitionCast(peli[0], actor)[j].Count >= 1)
                        {
                            peli[1] = partitionCast(peli[0], actor)[j];

                            if (partitionClasification(peli[1], clasification)[j].Count >= 1)
                            {
                                peli[2] = partitionClasification(peli[1], clasification)[j];
                            }
                        }
                    }
                }
            }


            if (value1 == "year" && value2 == "clasification" && value3 == "cast")
            {
                for (int j = 0; j < 2; j++)
                {
                    if (partitionYear(movies, year)[j].Count >= 1)
                    {
                        peli[0] = partitionYear(movies, year)[j];

                        if (partitionClasification(peli[0], clasification)[j].Count >= 1)
                        {
                            peli[1] = partitionClasification(peli[0], clasification)[j];

                            if (partitionCast(peli[1], actor)[j].Count >= 1)
                            {
                                peli[2] = partitionCast(peli[1], actor)[j];
                            }
                        }
                    }
                }
            }

            if (value1 == "clasification" && value2 == "year" && value3 == "cast")
            {
                for (int j = 0; j < 2; j++)
                {
                    if (partitionClasification(movies, clasification)[j].Count >= 1)
                    {
                        peli[0] = partitionClasification(movies, clasification)[j];

                        if (partitionYear(peli[0], year)[j].Count >= 1)
                        {
                            peli[1] = partitionYear(peli[0], year)[j];

                            if (partitionCast(peli[1], actor)[j].Count >= 1)
                            {
                                peli[2] = partitionCast(peli[1], actor)[j];
                            }
                        }
                    }
                }
            }


            if (value1 == "clasification" && value2 == "cast" && value3 == "year")
            {
                for (int j = 0; j < 2; j++)
                {
                    if (partitionClasification(movies, clasification)[j].Count >= 1)
                    {
                        peli[0] = partitionClasification(movies, clasification)[j];

                        if (partitionCast(peli[0], actor)[j].Count >= 1)
                        {
                            peli[1] = partitionCast(peli[0], actor)[j];

                            if (partitionYear(peli[1], year)[j].Count >= 1)
                            {
                                peli[2] = partitionYear(peli[1], year)[j];
                            }
                        }
                    }
                }
            }
            return peli;
        }
    }//
} //
