using Lab02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class ScoresEntryController : Controller
    {
        // GET: ScoresEntry
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet] public ActionResult Input() { 
            return View();
        }
        [HttpPost] 
        public ActionResult Output(Score s, FormCollection form)
        {
            bool isChecked = Convert.ToBoolean(form["checkbox"].Split(',')[0]);

			s.name = form["fullname"];
            s.math = float.Parse(form["math"]);
            s.physic = float.Parse(form["physic"]);
            s.chemistry = float.Parse(form["chemistry"]);
            s.isSpecial = isChecked;
            s.area = int.Parse(form["area"]);
			return View(s);
        }
    }
}