using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstChallenge.Models;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var comics = ComicBookManager.GetComicBooks();
            return View(comics);
        }

        public ActionResult Detail(int id)
        {
            var comics = ComicBookManager.GetComicBooks();
            // using this to find the comic with the id passed in
            // the => is a LINQ statement
            var returnComic = comics.FirstOrDefault(p => p.ComicBookId == id);
            return View(returnComic);
        }
    }
}