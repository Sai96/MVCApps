using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ViewResult MovieList()
        {
            var movies = GetMovies();

            return View(movies);
        }

        private object GetMovies()
        {
            return new List<Movies>
            {
                new Movies { Id = 1, Name = "Shrek" },
                new Movies { Id = 2, Name = "Wall-E" }
            };
        }
    }
}