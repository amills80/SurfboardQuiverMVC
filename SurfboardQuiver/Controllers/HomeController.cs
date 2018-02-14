using SurfboardQuiver.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SurfboardQuiver.Controllers
{
    public class HomeController : Controller
    {
        //private Repository _surfboardRepository = null;

        //public surfboardcontroller()
        //{
        //    _surfboardrepository = new repository();
        //}
        
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}