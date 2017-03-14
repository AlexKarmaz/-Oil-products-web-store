using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OilProducts.Models;
using System.Threading.Tasks;
using OilProducts.Filters;

namespace OilProducts.Controllers
{
    public class DeliveryCompanyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /DeliveryCompany/

        public async Task<ActionResult> Index()
        {
            return View( await db.DeliveryCompanies.ToListAsync());
        }

        // GET: /DeliveryCompany/Details/5
        [Authorize]
        [CustomAuthAttribute]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryCompany deliverycompany = db.DeliveryCompanies.Find(id);
            if (deliverycompany == null)
            {
                return HttpNotFound();
            }
            return View(deliverycompany);
        }

        // GET: /DeliveryCompany/Create
        [Authorize]
        [CustomAuthAttribute]
        public ActionResult Create()
        {
            return View();
        }

        // POST: /DeliveryCompany/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include="deliveryCompanyId,companyName,companyEmail,companyPhone,logo")] DeliveryCompany deliverycompany)
        {
            if (ModelState.IsValid)
            {
                db.DeliveryCompanies.Add(deliverycompany);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(deliverycompany);
        }

        // GET: /DeliveryCompany/Edit/5
        [Authorize]
        [CustomAuthAttribute]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryCompany deliverycompany = db.DeliveryCompanies.Find(id);
            if (deliverycompany == null)
            {
                return HttpNotFound();
            }
            return View(deliverycompany);
        }

        // POST: /DeliveryCompany/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [CustomAuthAttribute]
        [Authorize]
        public ActionResult Edit([Bind(Include="deliveryCompanyId,companyName,companyEmail,companyPhone,logo")] DeliveryCompany deliverycompany)
        {
            if (ModelState.IsValid)
            {
                db.Entry(deliverycompany).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(deliverycompany);
        }

        // GET: /DeliveryCompany/Delete/5
        [Authorize]
        [CustomAuthAttribute]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DeliveryCompany deliverycompany = db.DeliveryCompanies.Find(id);
            if (deliverycompany == null)
            {
                return HttpNotFound();
            }
            return View(deliverycompany);
        }

        // POST: /DeliveryCompany/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DeliveryCompany deliverycompany = db.DeliveryCompanies.Find(id);
            db.DeliveryCompanies.Remove(deliverycompany);
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
