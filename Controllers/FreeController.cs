using Lesson7ControllersLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson7ControllersLab.Controllers
{
    public class FreeController : Controller
    {
        // GET: Free
        public ActionResult Index()
        {
            return View("Index");
        }

        // GET: Free
        public ActionResult Bird(string name = "Unknown", int age = -1 , string color = "N/A")
            //public ActionResult Bird()
        {
            var model = new FreeBirdModel()
            {
                Name = name,
                Age = age,
                Color = color,
            };

            return View(model);
        }
    }
}