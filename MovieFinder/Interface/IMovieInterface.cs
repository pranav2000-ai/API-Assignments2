using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFinder.Models;
namespace MovieFinder.Interfaces
{
    interface IMovieInterface
    {
        List<Movie> GetAllMovies();
        List<Movie> GetMoviesByActor(string Actor);
        List<Movie> GetMoviesByDirector(string Director);
        List<Movie> GetMoviesByLang(string Lang);

        Movie GetMovie(int id);
        void AddMovie(Movie movie);
        void DeleteMovie(int id);
        void EditMovie(Movie movie);
    }
}