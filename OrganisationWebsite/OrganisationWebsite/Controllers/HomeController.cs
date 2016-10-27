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
            organisations org = new organisations();
            return View(org);
        }

        [HttpPost]
        public ActionResult RegOrg(organisations org)
        {
            if (ModelState.IsValid)
            {
                DB.organisations.Add(org);
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