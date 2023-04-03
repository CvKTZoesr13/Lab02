using Lab02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class SalaryController : Controller
    {
        // GET: Salary
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Input()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Output(Staff s, FormCollection form)
        {
            return View(s);
        }

    }
}