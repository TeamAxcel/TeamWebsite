using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamAxcelNewWebsite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult TheTeam()
        {
            return View();
        }
        public ActionResult Portfolio()
        {
            return View();
        }

    }
}