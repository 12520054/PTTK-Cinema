using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteCinema.Models;

namespace WebSiteCinema.Controllers
{
    public class HomeController : Controller
    {
        CinemaEntities db = new CinemaEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderInfoPartial()
        {
            var listHostesFilm = db.FILMs.ToList();
            return PartialView(listHostesFilm);
        }
    }
}