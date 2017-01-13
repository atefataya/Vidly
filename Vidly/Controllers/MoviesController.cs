using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random it will be called when we go to movies/random
        public ActionResult Random()
        {
            //List of movies
            var movie = new Movie()
            {
                Name = "Shrek!"
            };

            //List of customers
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1" },
                new Customer {Name = "customer 2" }
            };

            //View of movies and customers
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
        }


        // Attribute Routes in MVC 5
        [Route("movies/released/{year}/{month}")]

        public ActionResult ByReleaseDate(int year, string month)
        {
            return Content(year + "/" + month);
        }


        //This action will returned when we go to movies/genere/01/hulk
        [Route("movies/genere/{movieId}/{name}")]
            
        public ActionResult genere(int? movieId, string name)
        {
            if (!movieId.HasValue)
                movieId = 1;
            if (string.IsNullOrWhiteSpace(name))
                name = "Legend of the fall";

            return Content("The movie id is:" + movieId + " and the name is:" + name);
        }


        //This action will returned when we go to movies/edit/1 or movies/edit?id=1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
         }

        //This action will returned when we go to movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex = {0} & sortBy = {1}", pageIndex, sortBy));
        }
    }
}