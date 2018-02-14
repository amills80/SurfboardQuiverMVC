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

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}