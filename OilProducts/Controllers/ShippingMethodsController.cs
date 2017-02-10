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
    public class ShippingMethodsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /ShippingMethods/
        public ActionResult Index()
        {
            return View(db.ShippingMethods.ToList());
        }

        // GET: /ShippingMethods/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingMethods shippingmethods = db.ShippingMethods.Find(id);
            if (shippingmethods == null)
            {
                return HttpNotFound();
            }
            return View(shippingmethods);
        }

        // GET: /ShippingMethods/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /ShippingMethods/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="shippingMethodsId,shippingMethodName,taxeRate")] ShippingMethods shippingmethods)
        {
            if (ModelState.IsValid)
            {
                db.ShippingMethods.Add(shippingmethods);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shippingmethods);
        }

        // GET: /ShippingMethods/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingMethods shippingmethods = db.ShippingMethods.Find(id);
            if (shippingmethods == null)
            {
                return HttpNotFound();
            }
            return View(shippingmethods);
        }

        // POST: /ShippingMethods/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="shippingMethodsId,shippingMethodName,taxeRate")] ShippingMethods shippingmethods)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shippingmethods).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shippingmethods);
        }

        // GET: /ShippingMethods/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShippingMethods shippingmethods = db.ShippingMethods.Find(id);
            if (shippingmethods == null)
            {
                return HttpNotFound();
            }
            return View(shippingmethods);
        }

        // POST: /ShippingMethods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShippingMethods shippingmethods = db.ShippingMethods.Find(id);
            db.ShippingMethods.Remove(shippingmethods);
            db.SaveChanges();
            return RedirectToAction("Index");
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
