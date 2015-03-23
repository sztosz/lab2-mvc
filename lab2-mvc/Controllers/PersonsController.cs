using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab2_mvc.Controllers
{
    public class PersonsController : Controller
    {
        [AcceptVerbs("GET")]
        public ActionResult Create()
        {
            return View();
        }

        [AcceptVerbs("POST")]
        public ActionResult Result(string name, string surname, string sex, string job, List<String> hobby)
        {
            ViewBag.name = name;
            ViewBag.Surname = surname;
            ViewBag.sex = sex;
            ViewBag.job = job;
            
            ViewBag.hobby = "";
            foreach (var item in hobby)
            {
                ViewBag.hobby += String.Format("{0}; ", item);
            }

            return View();
        }
    }
}