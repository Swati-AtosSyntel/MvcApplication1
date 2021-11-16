using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee e = new Employee() { empid = 123, ename = "Swati", location = "Pune" };
            List<Employee> list = new List<Employee>()
            {
                new Employee(){empid=124,ename="Manisha",location="Pune"},
                new Employee(){empid=125,ename="Manish",location="Pune"},
                new Employee(){empid=126,ename="Nisha",location="Mumbai"},
                new Employee(){empid=127,ename="Nishant",location="Chennai"},
            };
            ViewData["employee"] = e;
            ViewBag.employees = list;
            // return View(e);
            return View(list);

        }
        public string showMessage()
        {
            return "Welcome to Mvc!!";
        }
        public JsonResult ShowData()
        {
            return Json(new { id = 123, name = "Swati" });
        }
        public ActionResult Index1()
        {
            TempData["myName"] = "Swati";
            return RedirectToAction("Index2");
        }
        public ActionResult Index2()
        {
            string name;
            if (TempData.ContainsKey("myName"))
            {
                name = TempData["myName"].ToString();
                TempData.Keep("myName");
            }
            return View();
        }
        public ActionResult ContactUs()
        {

            return View();
        }
    }
}