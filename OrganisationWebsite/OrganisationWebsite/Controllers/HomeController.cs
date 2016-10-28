using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrganisationWebsite.Models;

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

        [HttpGet]
        public ActionResult RegMember()
        {
            RegMemberViewModel model = new RegMemberViewModel(DB.organisations.ToList());
            return View(model);
        }

        [HttpPost]
        public ActionResult RegMember(RegMemberViewModel model)
        {
            if (ModelState.IsValid)
            {
                members member = model.member;
                DB.members.Add(member);
                DB.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ListOrgEndMember()
        {
            
            organisations organisation = new organisations();
            members members = new members();
            System.Collections.ArrayList DBLists = new System.Collections.ArrayList();
            DBLists.Add(DB.organisations.ToList());
            DBLists.Add(DB.members.ToList());
            return View(DBLists);
        }
    }
}