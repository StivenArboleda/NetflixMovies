﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies
{
    class Data
    {
        private static List<Movies> movie = new List<Movies>();

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


        public void loadData()
        {

            using (var reader = new StreamReader(@"C:\Users\prestamo\Downloads\archive\netflix_titles.csv"))
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

            public static void Main(String[] args)
        {

        }

    }
}