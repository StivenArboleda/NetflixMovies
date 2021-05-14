using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetflixMovies.ui;

namespace NetflixMovies
{
    class Data
    {
        public List<Movies> movie = new List<Movies>();

        // de cadena 

        public List<Movies> IdMovieList(string id)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.MovieId.Equals(id))
                {
                    answer.Add(m);

                }
            }
            return answer;

        }

        public List<Movies> TitleMovieList(string tit)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.Title.Contains(tit))
                {
                    answer.Add(m);
                }
            }
            return answer;
        }

        public List<Movies> PublishedDateMovieList(string pub)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.DatePublishedNet.Contains(pub))
                {
                    answer.Add(m);
                }
            }
            return answer;
        }

        public List<Movies> DirectorMovieList(string dir)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.Director.Contains(dir))
                {
                    answer.Add(m);
                }
            }
            return answer;
        }

        public List<Movies> CastMovieList(string cas)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.Cast.Contains(cas))
                {
                    answer.Add(m);
                }
            }
            return answer;
        }


        public List<Movies> ContryOfOriginMovieList(string org)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.CountryOfOrigin.Equals(org))
                {
                    answer.Add(m);
                }
            }
            return answer;
        }


        //numericos

        public List<Movies> ReleaseYearMovieList(int real)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.ReleaseYear >= (real) && (m.ReleaseYear < (real + 5)))
                {
                    answer.Add(m);
                }
            }
            return answer;

        }

        public List<Movies> DurationMovieList(int mins)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.MinutesOfMovie >= (mins) && (m.MinutesOfMovie < (mins + 10)))
                {
                    answer.Add(m);
                }
            }
            return answer;
        }

        //categorico

        public List<Movies> ClasificationMovieList(string clas)
        {
            List<Movies> answer = new List<Movies>();
            foreach (Movies m in movie)
            {
                if (m.Clasification.Contains(clas))
                {
                    answer.Add(m);
                }
            }
            return answer;
        }

        // Methods for graphs 

        public Dictionary<int, int> MoviesPerYear()
        {
            Dictionary<int, int> answer = new Dictionary<int, int>(); 
            for(int i=1925; i<=2021; i++)
            {
                int cont = 0;
                foreach(Movies m in movie)
                {
                    if(m.ReleaseYear == i)
                    {
                        cont++;
                    }
                }
                answer.Add(i, cont);
            }
            return answer;
        }

        public Dictionary<string, int> MoviesByDuration()
        {
            Dictionary<string, int> answer = new Dictionary<string, int>();
            for (int i = 0; i <= 200; i+=20)
            {
                int cont = 0;
                foreach (Movies m in movie)
                {
                    if (m.MinutesOfMovie >= i && m.MinutesOfMovie < i+20)
                    {
                        cont++;
                    }
                }
                answer.Add(i+"-"+ (i+20), cont);
            }
            return answer;
        }

        public Dictionary<string, int> MoviesByGenre()
        {
            Dictionary<string, int> answer = new Dictionary<string, int>();
            List<string> genre = new List<string>();
            genre.Add("Comedies");
            genre.Add("Dramas");
            genre.Add("Romantic Movies");
            genre.Add("Action & Adventure");
            genre.Add("Thriller");
            genre.Add("Sci-Fi & Fantasy");
            genre.Add("Classic Movies");
            foreach (String g in genre)
            {
                int cont = 0;
                foreach (Movies m in movie)
                {
                    if (m.Clasification.Contains(g))
                    {
                        cont++;
                    }
                }
                answer.Add(g, cont);
            }
            return answer;
        }

        public Dictionary<string, int> MoviesByDirector()
        {
            Dictionary<string, int> answer = new Dictionary<string, int>();
            List<string> director = new List<string>();
            director.Add("Jay Champman");
            director.Add("Jay Karas");
            director.Add("Jay Roach");
            director.Add("Jeff Baena");
            director.Add("Jeff Nichols");
            director.Add("Jeremy Saulnier");
            director.Add("Joe Berlinger");
            foreach (String d in director)
            {
                int cont = 0;
                foreach (Movies m in movie)
                {
                    if (m.Director.Contains(d))
                    {
                        cont++;

                    }
                }
                answer.Add(d, cont);
            }
            return answer;
        }

        public Dictionary<string, int> MoviesByCountry()
        {
            Dictionary<string, int> answer = new Dictionary<string, int>();
            List<string> country = new List<string>();
            country.Add("United States");
            country.Add("Canada");
            country.Add("Argentina");
            country.Add("China");
            country.Add("Egypt");
            country.Add("France");
            country.Add("India");
            foreach (String d in country)
            {
                int cont = 0;
                foreach (Movies m in movie)
                {
                    if (m.CountryOfOrigin.Contains(d))
                    {
                        cont++;

                    }
                }
                answer.Add(d, cont);
            }
            return answer;
        }

        public Dictionary<int, int> MoviesPerYearLine()
        {
            Dictionary<int, int> answer = new Dictionary<int, int>();
            for (int i = 1925; i <= 2021; i++)
            {
                int cont = 0;
                foreach (Movies m in movie)
                {
                    if (m.ReleaseYear == i)
                    {
                        cont++;
                    }
                }
                answer.Add(i, cont);
            }
            return answer;
        }

        //loadData

        public void loadData()
        {

            using (var reader = new StreamReader(File.OpenRead("..\\..\\Data\\netflix_titles.csv")))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    if (values[1] == "Movie")
                    {
                        string movieId = values[0];
                        string title = values[2];
                        string director = values[3];
                        string cast = values[4];
                        string countryOfOrigin = values[5];
                        string datePublishedNet = values[6];
                        int releaseYear = Int32.Parse(values[7]);
                        var temp = values[9].Split(' ');
                        int minutesOfMovie = Int32.Parse(temp[0]);
                        string clasification = values[10];
                        Movies mov = new Movies(movieId, title, director, cast, countryOfOrigin, datePublishedNet, releaseYear, minutesOfMovie, clasification);
                        movie.Add(mov);

                    }

                }
            }
        }
        // Set and Get 
        public List<Movies> list { get => movie; set => movie = value; }


    }
}
