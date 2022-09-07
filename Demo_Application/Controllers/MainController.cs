using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo_Application.Models;

namespace Demo_Application.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        //public ActionResult Index()
        public ActionResult Random()
        {

            var main = new Main() { Name = "Hello...!!" };
                return View(main);
        }
    }
}