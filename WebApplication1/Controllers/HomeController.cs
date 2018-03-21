using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Games()
        {
            ViewBag.Message = "Info about games";

            return View();
        }

        public ActionResult Guitars()
        {
            ViewBag.Message = "Info about guitars";

            return View();
        }
    }
}