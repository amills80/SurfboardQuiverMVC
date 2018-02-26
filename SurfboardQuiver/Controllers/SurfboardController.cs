using SurfboardQuiver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurfboardQuiver.Data;
using System.Net;

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

            /// if there isn't any length field validation errors, then make sure field is between 2 and 13 ft
            ValidateEntryLength(newBoard);

            /// Make sure width field is also between 12 - 60 inches
            ValidateEntryWidth(newBoard);

            if (ModelState.IsValid)
            {
                _surfboardRepository.AddSurfboard(newBoard);
                List<Surfboard> surfboards = _surfboardRepository.GetSurfboards();
                return RedirectToAction("Index");
            }

            return View(newBoard);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Surfboard entry = _surfboardRepository.GetSurfboard((int)id);

            if (entry == null)
            {
                return HttpNotFound();
            }

            return View(entry);
        }

        [HttpPost]
        public ActionResult Edit(Surfboard entry)
        {
            ValidateEntryLength(entry);
            ValidateEntryWidth(entry);

            if (ModelState.IsValid)
            {
                _surfboardRepository.UpdateSurfboard(entry);
                return RedirectToAction("Index");
            }
            return View(entry);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Surfboard entry = _surfboardRepository.GetSurfboard((int)id);

           if (entry == null)
            {
                return HttpNotFound();
            }

            return View(entry);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _surfboardRepository.DeleteSurfboard(id);

            return RedirectToAction("Index");
        }

        private void ValidateEntryWidth(Surfboard newBoard)
        {
            if (ModelState.IsValid && newBoard.Width <= 12 && newBoard.Width >= 60)
            {
                ModelState.AddModelError("Width", "");
            }
        }

        private void ValidateEntryLength(Surfboard newBoard)
        {
            if (ModelState.IsValid && newBoard.Length <= 2 && newBoard.Length >= 13)
            {
                ModelState.AddModelError("Length", "");
            }
        }

    }
}