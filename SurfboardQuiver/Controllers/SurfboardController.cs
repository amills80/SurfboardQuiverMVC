using SurfboardQuiver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurfboardQuiver.Data;

namespace SurfboardQuiver.Controllers
{
    public class SurfboardController : Controller
    {
        private Repository _surfboardRepository = null;

        public SurfboardController()
        {
            _surfboardRepository = new Repository();
        }

        public ActionResult Index()
        {
            var surfboards = _surfboardRepository.GetSurfboards();

            return View(surfboards);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var surfboard = _surfboardRepository.GetSurfboard((int)id);
            return View(surfboard);
        }

        public ActionResult Create()
        {
            return View();
        }

        //public ActionResult Add()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Create(string brand, string model
            , string shape, string finSetup, float? length, float? width
            , string desc, float? rating)
        {
            //ViewBag.Brand = ModelState["Brand"].Value.AttemptedValue;
            //ViewBag.Model = ModelState["Model"].Value.AttemptedValue;
            //ViewBag.SHape = ModelState["Shape"].Value.AttemptedValue;
            //ViewBag.FinSetup = ModelState["FinSetup"].Value.AttemptedValue;
            //ViewBag.Length = ModelState["Length"].Value.AttemptedValue;
            //ViewBag.Width = ModelState["Width"].Value.AttemptedValue;
            //ViewBag.Description = ModelState["Description"].Value.AttemptedValue;
            //ViewBag.Rating = ModelState["Rating"].Value.AttemptedValue;

            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}