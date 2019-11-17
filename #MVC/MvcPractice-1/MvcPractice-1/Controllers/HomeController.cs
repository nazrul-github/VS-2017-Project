using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           List<string> aList = new List<string>(){"USA","UK","Canada","Japan"};
            
           ViewBag.Countries = aList;
           return View();
        }
    }
}