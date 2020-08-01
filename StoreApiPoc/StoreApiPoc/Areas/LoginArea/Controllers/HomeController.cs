using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApiPoc.Areas.LoginArea.Controllers
{
    public class HomeController : Controller
    {
        // GET: LoginArea/Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Registration()
        //{
        //    return View();
        //}

    }
}