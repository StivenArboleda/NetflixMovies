using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixMovies
{
    class Movies
    {

        //Atributtes

        private string movieId;
        private string title;
        private string director;
        private string cast;
        private string countryOfOrigin;
        private string datePublishedNet;
        private int releaseYear;
        private int minutesOfMovie;
        private string clasification;


        public Movies(string movieId, string title, string director, string cast, string countryOfOrigin, string datePublishedNet, int releaseYear, int minutesOfMovie, string clasification)
        {
            this.MovieId = movieId;
            this.Title = title;
            this.Director = director;
            this.Cast = cast;
            this.CountryOfOrigin = countryOfOrigin;
            this.DatePublishedNet = datePublishedNet;
            this.ReleaseYear = releaseYear;
            this.MinutesOfMovie = minutesOfMovie;
            this.Clasification = clasification;

        }

        public string MovieId { get => movieId; set => movieId = value; }
        public string Title { get => title; set => title = value; }
        public string Director { get => director; set => director = value; }
        public string Cast { get => cast; set => cast = value; }
        public string CountryOfOrigin { get => countryOfOrigin; set => countryOfOrigin = value; }
        public string DatePublishedNet { get => datePublishedNet; set => datePublishedNet = value; }
        public int ReleaseYear { get => releaseYear; set => releaseYear = value; }
        public int MinutesOfMovie { get => minutesOfMovie; set => minutesOfMovie = value; }
        public string Clasification { get => clasification; set => clasification = value; }

        public string toString()
        {
            return (MovieId + " ; " + Title + " ; " + Director + " ; " + Cast + " ; " + CountryOfOrigin + " ; " + DatePublishedNet + " ; " + ReleaseYear + " ; " + MinutesOfMovie + " ; " + Clasification + ". ");
        }

        public string getByNumber (int num)
        {
            switch (num)
            {
                case 1:
                    return title;
                    break;
                case 2:
                    return director;
                    break;
                case 3:
                    return countryOfOrigin;
                    break;
                case 4:
                    return datePublishedNet;
                    break;
                case 5:
                    return releaseYear + " ";
                    break;
                case 6:
                    return minutesOfMovie + " ";
                    break;
                case 7:
                    return clasification;
                    break;
            }
            return null;
        }



    }
}