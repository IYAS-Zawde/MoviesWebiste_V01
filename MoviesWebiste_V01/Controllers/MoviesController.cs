using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesWebiste_V01.Models;
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
            string directorName;
            string cast; // List Of Actors
            string categories; // List of Categories that Movie Belong
            double rating_avg;
            List<MoviesWebiste_V01.Models.CommentDetials> Ratings_Comments = new List<Models.CommentDetials>();
            using (var dbContext = new MoviesWebsiteDBEntities()) {
                movie = dbContext.movies.Where(x => x.ID == id).First();
                directorName = dbContext.directors.Where(x => x.ID == movie.director_id).Select(z=> z.name).FirstOrDefault();
                cast = String.Join(",", movie.actors.Select(x => x.name).ToList());
                categories = String.Join(",", movie.categories.Select(z => z.category1).ToList());
                if (movie.ratings.Count() == 0)
                {
                    rating_avg = 0;

                }
                else
                {
                    rating_avg = (double)movie.ratings.Select(z => z.rate).ToList().Average();
                    foreach (var item in movie.ratings)
                    {
                        Ratings_Comments.Add(
                            new Models.CommentDetials
                            {
                                customerName = dbContext.customers.Where(cus => cus.ID == item.customer_id).Select(cusName => cusName.name).FirstOrDefault(),
                                comment = item.comment,
                                rate = (int)item.rate
                            });
                    }
                }
            }
            

            ViewBag.directorName = directorName;
            ViewBag.cast = cast;
            ViewBag.categories = categories;
            ViewBag.rating_avg = rating_avg;
            ViewBag.Ratings_Comments = Ratings_Comments;
            return View(movie);
        }

        public ActionResult SearchActorsName(string q)
        {

            List<MoviesWebiste_V01.Models.SearchResult> actors = new List<MoviesWebiste_V01.Models.SearchResult>();
            if (q == "")
            {
                return PartialView("_SearchResult", actors);
            }
            using (var dbContext = new MoviesWebsiteDBEntities())
            {
                actors = dbContext.actors.Where(x => x.name.Contains(q)).Select(z => new SearchResult { id = z.ID, value = z.name }).ToList();
            }
                return PartialView("_SearchResult", actors);
        }

        public ActionResult SearchDirectorName(string q)
        {

            List<MoviesWebiste_V01.Models.SearchResult> dirctors = new List<MoviesWebiste_V01.Models.SearchResult>();
            if (q == "")
            {
                return PartialView("_SearchResult", dirctors);
            }
            using (var dbContext = new MoviesWebsiteDBEntities())
            {
                dirctors = dbContext.directors.Where(x => x.name.Contains(q)).Select(z => new SearchResult{ id = z.ID, value = z.name }).ToList();
            }
            return PartialView("_SearchResult", dirctors);
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
