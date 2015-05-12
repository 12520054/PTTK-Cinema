using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CinemaWebsite.Models;

namespace CinemaWebsite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        CinemaEntities db = new CinemaEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeaderInfoPartial()
        {
            var listHostesFilm = db.FILM.Take(1).ToList();
            return PartialView(listHostesFilm);
        }
	}
}