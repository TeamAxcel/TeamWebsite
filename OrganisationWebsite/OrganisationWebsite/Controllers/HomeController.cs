using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OrganisationWebsite.Controllers
{
    public class HomeController : Controller
    {
        WebsiteDBEntities DB;

        public HomeController()
        {
            DB = new WebsiteDBEntities();
        }

        // GET: Home
        [HttpGet]
        public ActionResult RegOrg()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegOrg(organisations organisation)
        {
            if (ModelState.IsValid)
            {
                DB.organisations.Add(organisation);
                DB.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ListOrgEndMember(organisations organisation)
        {
            return View(organisation);
        }
    }
}