using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieFinder.Services;
using MovieFinder.Models;
namespace MovieFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieFinderController : ControllerBase
    {
        private readonly MovieService _service;
        public MovieFinderController()
        {
            _service = new MovieService();
        }
        //define action-methods
        [HttpGet]
        [Route("GetAllMovies")]
        public IActionResult GetAllMovies()
        {
            try
            {
                List<Movie> movies = _service.GetAllMovies();
                return StatusCode(200, movies);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMovieById/{id}")]
        public IActionResult GetMovieById(int id)
        {
            try
            {
                Movie movie = _service.GetMovie(id);
                if (movie != null)
                    return StatusCode(200, movie);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMovieByActor/{Actor}")]
        public IActionResult GetMovieByActor(string Actor)
        {
            try
            {
                List<Movie> list = _service.GetMoviesByActor(Actor);
                if (list != null)
                    return StatusCode(200, list);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetMovieByDirector/{Director}")]
        public IActionResult GetMovieByDirector(string Director)
        {
            try
            {
                List<Movie> list = _service.GetMoviesByDirector(Director);
                if (list != null)
                    return StatusCode(200, list);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("AddMovie")]
        public IActionResult AddMovie(Movie movie)
        {
            try
            {
                _service.AddMovie(movie);
                return StatusCode(200, "Record Added");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("GetMovieByLang/{Lang}")]
        public IActionResult GetMovieByLang(string Lang)
        {
            try
            {
                List<Movie> list = _service.GetMoviesByLang(Lang);
                if (list != null)
                    return StatusCode(200, list);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("EditMovie")]
        public IActionResult EditMovie(Movie movie)
        {
            try
            {
                _service.EditMovie(movie);
                return StatusCode(200, "Record Updated");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("DeleteMovie/{id}")]
        public IActionResult DeleteMovie(int id)
        {
            try
            {
                _service.DeleteMovie(id);
                return StatusCode(200, "Record Deleted");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
