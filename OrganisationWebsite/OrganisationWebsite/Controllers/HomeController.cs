﻿using System;
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
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(organisations organisation)
        {
            if (ModelState.IsValid)
            {
                DB.organisations.Add(organisation);
                DB.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}