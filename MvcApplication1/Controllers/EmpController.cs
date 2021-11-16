using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class EmpController : Controller
    {
        public static List<Employee> list = new List<Employee>();
        // GET: Emp
        public ActionResult Index()
        {
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid)
            {
                list.Add(e);
                return View("Index", list);
            }
            return View();
        }
    }
}