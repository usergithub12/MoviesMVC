﻿using MoviesMVC.Models;
using MoviesMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Shrek!"};

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            var customers = new List<Customer>
         {
             new Customer {Name="Customer 1" },
                 new Customer {Name="Customer 1" },
                     new Customer {Name="Customer 1" },
         };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id); 
        //}

        ////movies
        //public ActionResult Index(int? pageIndex,string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }
        //    if (String.IsNullOrEmpty(sortBy)){
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageindex={0}&sortBy={1}", pageIndex, sortBy));
        //}
        //[Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //     return Content(year + "/" + month);
        //}




    }
}