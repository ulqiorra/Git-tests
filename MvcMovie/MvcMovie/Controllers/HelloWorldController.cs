using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/

        public ActionResult Index()//string Index()
        {
            return View();//"This is my <b>default</b> action...";
        }

        //
        //GET: /HelloWorld/Welcome

        public ActionResult Welcome(string name, int numTimes = 1)//string Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
            //return HttpUtility.HtmlEncode("Hello "+ name + ", NumTimes is: " + numTimes);//"This is the Welcome action method...";
        }

    }
}
