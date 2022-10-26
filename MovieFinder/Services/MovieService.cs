using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFinder.Interfaces;
using MovieFinder.Models;

namespace MovieFinder.Services
{
    public class MovieService : IMovieInterface
    {
        public static List<Movie> list = new List<Movie>();
        public void AddMovie(Movie movie)
        {
            list.Add(movie);
        }

        public void DeleteMovie(int id)
        {
            Movie movie = list.SingleOrDefault(i => i.MovieId == id);
            list.Remove(movie);
        }

        public Movie GetMovie(int id)
        {
            Movie movie = list.SingleOrDefault(i => i.MovieId == id);
            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            return list;
        }

        public List<Movie> GetMoviesByActor(string Actor)
        {
            List<Movie> list1 = new List<Movie>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Actor == Actor)
                {
                    list1.Add(list[i]);
                }
            }
            return list1;
        }

        public List<Movie> GetMoviesByDirector(string Director)
        {
            List<Movie> list1 = new List<Movie>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Director == Director)
                {
                    list1.Add(list[i]);
                }
            }
            return list1;
        }

        public List<Movie> GetMoviesByLang(string Lang)
        {
            List<Movie> list1 = new List<Movie>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Lang == Lang)
                {
                    list1.Add(list[i]);
                }
            }
            return list1;
        }
        public void EditMovie(Movie movie)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MovieId == movie.MovieId)
                {
                    list[i] = movie;
                    break;
                }
            }
        }
    }
}