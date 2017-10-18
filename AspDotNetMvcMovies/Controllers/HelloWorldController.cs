using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetMvcMovies.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public ActionResult Welcome(string name, int iterationsCount)
        {
            ViewBag.Message = $"Hello {name}";
            ViewBag.IterationsCount = iterationsCount;
            return View();
        }
    }
}