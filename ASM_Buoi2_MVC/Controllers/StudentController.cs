using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASM_Buoi2_MVC.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            TempData["Name"] = "Nguyen Hoai Nam";
            TempData["Age"] = 28;
            TempData["Address"] = "Ha Noi";
            return View("ShowData");
        }

        public ActionResult ShowData()
        {
            return View();
        }
    }
}