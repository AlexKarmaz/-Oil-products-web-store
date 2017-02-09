using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OilProducts.Models;

namespace OilProducts.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /Customers/
        public ActionResult Index()
        {
            return View(db.Customers.ToList());
        }

        // GET: /Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Customers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "firstName,lastName,companyName,country,state,city,postalCode,address,phoneNumber,email")] Customers customers)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customers);
                db.SaveChanges();
                return RedirectToAction("Create", "Orders", new { id = customers.customersId});
            }


            return View(customers);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
