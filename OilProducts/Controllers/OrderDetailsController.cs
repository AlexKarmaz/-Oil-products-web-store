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
    public class OrderDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /OrderDetails/
        public ActionResult Index()
        {
            return View(db.OrderDetails.ToList());
        }

        // GET: /OrderDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetails orderdetails = db.OrderDetails.Find(id);
            if (orderdetails == null)
            {
                return HttpNotFound();
            }
            return View(orderdetails);
        }

        // GET: /OrderDetails/Create
        public ActionResult Create(int? id , int? prodId)
        {
            if (id == null || prodId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products newprod = db.Products.Find(prodId);
            OrderDetails orderDetails = new OrderDetails { orderId = (int)id , productName = newprod.productName, UnitPrice = newprod.price};
            return View(orderDetails);
        }

        // POST: /OrderDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OrderDetails orderdetails)
        {
            if (ModelState.IsValid)
            {
                db.OrderDetails.Add(orderdetails);
                db.SaveChanges();
                return RedirectToAction("Create", "BankPayments", new { id = orderdetails.orderId });
            }

            return View(orderdetails);
        }

        // GET: /OrderDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetails orderdetails = db.OrderDetails.Find(id);
            if (orderdetails == null)
            {
                return HttpNotFound();
            }
            return View(orderdetails);
        }

        // POST: /OrderDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="orderDetailsId,orderId,productId,quantity,UnitPrice,discount")] OrderDetails orderdetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orderdetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orderdetails);
        }

        // GET: /OrderDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OrderDetails orderdetails = db.OrderDetails.Find(id);
            if (orderdetails == null)
            {
                return HttpNotFound();
            }
            return View(orderdetails);
        }

        // POST: /OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OrderDetails orderdetails = db.OrderDetails.Find(id);
            db.OrderDetails.Remove(orderdetails);
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
