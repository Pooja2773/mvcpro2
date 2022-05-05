using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcpro2.Controllers
{
    public class createController : Controller
    {
        // GET: create
        public ActionResult Index()
        {
            string m = ".net mvc project";
            ViewBag.msg = m;
            return View();
        }
        public ActionResult home1()
        {
            string m = "chetu";
            ViewBag.msg = m;
            return View();
        }
        public ActionResult aboutus()
        {
            string m = "software development";
            ViewBag.msg = m;
            return View();
        }
    }
}