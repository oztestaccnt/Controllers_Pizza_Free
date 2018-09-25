using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson7ControllersLab.Controllers
{
    public class CarController : Controller     
    {
        public ActionResult AboutCars()
        {
            ViewBag.Title = "About";
            ViewBag.CarModel = "Lexus";
            ViewBag.Tree = "Oak";

            return View();
        }
    }
}