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
            List<Surfboard> surfboards = _surfboardRepository.GetSurfboards();
            //var surfboards = _surfboardRepository.GetSurfboards();

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

        [HttpPost]
        public ActionResult Create(Surfboard newBoard)
        {
            // TODO: during validation of board dim's: subrstring / remove the foot / inch characters in case they get submitted
            if (ModelState.IsValid)
            {
                _surfboardRepository.AddSurfboard(newBoard);

                List<Surfboard> surfboards = _surfboardRepository.GetSurfboards();

                return RedirectToAction("Index");
            }

            return View(newBoard);
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}