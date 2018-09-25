using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Lesson7ControllersLab.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Bake()
        {
            ViewBag.Title = "Bake the Pizza";
            ViewBag.Style = "All You Can Eat Pizza";
            ViewBag.Day = "Tuesday";

            return View();
        }

        public ActionResult Work(int? id, string name)
        {
            ViewBag.hrs = id;
            ViewBag.hrmin = name;

            return View();
        }
    }
}