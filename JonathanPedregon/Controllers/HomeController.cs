using JonathanPedregon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JonathanPedregon.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var model = new ContactViewModel();
            return View(model);
        }

        public ActionResult Sites()
        {
            var site1 = new SiteViewModel("http://pluspng.com/img-png/adidas-3504.png", "jonathanpedregon.com", "December 14, 2017", "Personal site intended to showcase achievements");
            var site2 = new SiteViewModel("http://pluspng.com/img-png/adidas-3504.png", "Scorekeeper","Soon", "Planned scorekeeper for card games");
            var sites = new List<SiteViewModel>() { site1, site2 };
            return View(sites);
        }

        public ActionResult Resume()
        {
            return View();
        }
    }
}