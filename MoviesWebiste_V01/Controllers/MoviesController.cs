using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesWebiste_V01.Controllers
{
    public class MoviesController : Controller
    {

        // GET: Movies
        public ActionResult Index()
        {
            IEnumerable<MoviesWebiste_V01.movie> Movies;
            List<MoviesWebiste_V01.category> MovieGenre;
            using (var dbContext = new MoviesWebsiteDBEntities())
            {
                Movies = dbContext.movies.Take(10).ToList();
                MovieGenre = dbContext.categories.ToList();
            }
            
            ViewBag.Genres = MovieGenre;
            return View(Movies);
        }

        [HttpGet]
        public ActionResult Search(string movie_name, string director_name, string actor_name, int movie_genre)
        {
            /*
             * To Edite
             */
            List<MoviesWebiste_V01.category> MovieGenre;
            IEnumerable<MoviesWebiste_V01.movie> SearchResult;
            using(var dbContext = new MoviesWebsiteDBEntities())
            {
                SearchResult = dbContext.movies.Where(x => x.name.Contains(movie_name)).ToList();
                MovieGenre = dbContext.categories.ToList();
            }
            ViewBag.Genres = MovieGenre;
            return View("Index", SearchResult);
        }

        public ActionResult StartWith(string letter)
        {
            List<MoviesWebiste_V01.category> MovieGenre;
            IEnumerable<MoviesWebiste_V01.movie> SearchResult;
            using (var dbContext = new MoviesWebsiteDBEntities())
            {
                SearchResult = dbContext.movies.Where(x => x.name.StartsWith(letter)).ToList();
                MovieGenre = dbContext.categories.ToList();
            }

            ViewBag.Genres = MovieGenre;
            return View("Index", SearchResult);
        }
        // GET: Movies/Details/5
        public ActionResult Details(int id)
        {
            MoviesWebiste_V01.movie movie;
            var dbContext = new MoviesWebsiteDBEntities();
            movie = dbContext.movies.Where(x => x.ID == id).First();
            return View();
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movies/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movies/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
