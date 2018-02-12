using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurfboardQuiver.Controllers
{
    public class SurfboardController : Controller
    {

        public ActionResult Details()
        {
            ViewBag.Make = "McTavish";
            ViewBag.Model = "Sumo";
            ViewBag.Length = 7.8;
            ViewBag.Style = "Midlength";
            ViewBag.Fins = "Single";
            ViewBag.Notes = "Sporty, fun 2+1 board. Great for pitchy and clean-face waves.";
            ViewBag.Image = @"C:\Users\aelon\SurfboardQuiver\SurfboardQuiver\images\McTavish_Sumo.jpg";
            ViewBag.DisplayText = ViewBag.Make + ": " + ViewBag.Model + " - " + ViewBag.Length + "'";

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}