using Lab02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab02.Controllers
{
    public class EmployeeManagementController : Controller
    {
        // GET: EmployeeManagement
        /// <summary>
        /// phương thức này có view là form để hiển thị dữ liệu
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Input()
        {
            return View();
        }

        [HttpPost]   // giao thức http POST, dùng để đưa dữ liệu từ phía client -> server
        // phương thức này nhận dữ liệu từ form phía client và xử lý
        public ActionResult CalSalaryV1()
        {
            string id = Request["id"];
            string name = Request["name"];
            int amount = int.Parse(Request["amount"]);
            double salary = double.Parse(Request["salary"]);
            Employee e = new Employee(id, name, amount, salary);
            return View(e);
        }


        [HttpPost]
        public ActionResult CalSalaryV2(string id, string name, int amount, double salary)
        {
            Employee e = new Employee(id, name, amount, salary);

            return View("CalSalaryV1", e); // dùng chung 1 view là CalSalaryV1, trả về 1 đối tượng Employee - Model
        }
        [HttpPost]
        public ActionResult CalSalaryV3(Employee emp)
        {
            ViewData["test"] = "test";
            return View("CalSalaryV1",emp);
        }

        [HttpPost]
        public ActionResult CalSalaryV4(Employee emp, FormCollection form)
        {
            emp.id = form["id"];
            emp.name = form["name"];
            emp.amount = int.Parse(form["amount"]);
            emp.salary = double.Parse(form["salary"]);


            return View("CalSalaryV1", emp);
        }
    }
}