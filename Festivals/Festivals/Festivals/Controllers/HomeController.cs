using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Festivals.Controllers
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

        public ActionResult News()
        {
            ViewBag.Message = "News.";

            return View();
        }

        public ActionResult Maps()
        {
            ViewBag.Message = "Map.";

            return View();
        }

        public ActionResult Tickets()
        {
            ViewBag.Message = "Ticket.";

            return View();
        }

        public ActionResult Buy()
        {
            ViewBag.Message = "Buy.";

            return View();
        }

        public ActionResult Confirmation()
        {
            ViewBag.Message = "Confirmation.";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Gallery.";

            return View();
        }

        public ActionResult Untold()
        {
            ViewBag.Message = "Untold.";

            return View();
        }

        public ActionResult Neversea()
        {
            ViewBag.Message = "Neversea.";

            return View();
        }

        public ActionResult Sunwaves()
        {
            ViewBag.Message = "Sunwaves.";

            return View();
        }

        public ActionResult Sunset()
        {
            ViewBag.Message = "Sunset.";

            return View();
        }

        public ActionResult Electric_Castle()
        {
            ViewBag.Message = "Electric_Castle.";

            return View();
        }

        public ActionResult Summer_Well()
        {
            ViewBag.Message = "Summer_Well.";

            return View();
        }
        public ActionResult Awake()
        {
            ViewBag.Message = "Awake.";

            return View();
        }

        public ActionResult Afterhills()
        {
            ViewBag.Message = "Afterhills.";

            return View();
        }

        public ActionResult Dakini()
        {
            ViewBag.Message = "Dakini.";

            return View();
        }

        public ActionResult El_Carrusel()
        {
            ViewBag.Message = "El_Carrusel.";

            return View();
        }
    }
}