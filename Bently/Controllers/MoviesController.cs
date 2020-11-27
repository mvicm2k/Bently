using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bently.Models;
using Bently.ViewModels;

namespace Bently.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Shrek!" };
            var customers = new List<Customer> {
                new Customer { Name = "Customer 1"},
                new Customer {Name = "Customer 2"}

            };

            var viewModel = new RandomMovieViewModel { 
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Name ="Troy", Id = 1},
                new Movie {Name ="Power", Id= 2 },
                new Movie {Name ="Warrior", Id = 3},
                new Movie {Name ="Fringe", Id = 4},
                new Movie {Name ="Thor", Id = 5}

            };
        }
    }
}