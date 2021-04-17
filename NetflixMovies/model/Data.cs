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

        //loadData

            public void loadData()
        {

            using (var reader = new StreamReader(File.OpenRead(@"C:\Users\prestamo\Downloads\archive\netflix_titles.csv")))
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

    }
}
