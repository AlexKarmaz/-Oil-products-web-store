﻿using System;
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
    public class BankPaymentsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /BankPayments/
        public ActionResult Index()
        {
            return View(db.BankPayments.ToList());
        }

        // GET: /BankPayments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankPayments bankpayments = db.BankPayments.Find(id);
            if (bankpayments == null)
            {
                return HttpNotFound();
            }
            return View(bankpayments);
        }

        // GET: /BankPayments/Create
        public ActionResult Create(int? id = 3)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankPayments bankPayments = new BankPayments { orderId = (int)id };
            return View(bankPayments);
        }

        // POST: /BankPayments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BankPayments bankpayments){
            if (ModelState.IsValid)
            {
                bankpayments.paymentDate = DateTime.Now;
                db.BankPayments.Add(bankpayments);
                db.SaveChanges();
                Orders order = db.Orders.Find(bankpayments.orderId);
                order.paymentsId = bankpayments.bankPaymentsId;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bankpayments);
        }

        // GET: /BankPayments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankPayments bankpayments = db.BankPayments.Find(id);
            if (bankpayments == null)
            {
                return HttpNotFound();
            }
            return View(bankpayments);
        }

        // POST: /BankPayments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="bankPaymentsId,orderId,paymentAmount,paymentDate,nameBank,swift,accountNumber,passportSeries,passportId")] BankPayments bankpayments)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bankpayments).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bankpayments);
        }

        // GET: /BankPayments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BankPayments bankpayments = db.BankPayments.Find(id);
            if (bankpayments == null)
            {
                return HttpNotFound();
            }
            return View(bankpayments);
        }

        // POST: /BankPayments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BankPayments bankpayments = db.BankPayments.Find(id);
            db.BankPayments.Remove(bankpayments);
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