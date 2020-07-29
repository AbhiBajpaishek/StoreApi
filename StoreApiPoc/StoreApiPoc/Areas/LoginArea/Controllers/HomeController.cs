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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }
    }
}