using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Apoteka.Models;

namespace Apoteka.Controllers
{
    public class LeksController : Controller
    {
        private BazaApotekaEntities db = new BazaApotekaEntities();

        // GET: Leks
        public ActionResult Index()
        {
            return View(db.Leks.ToList());
        }

        // GET: Leks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lek lek = db.Leks.Find(id);
            if (lek == null)
            {
                return HttpNotFound();
            }
            return View(lek);
        }

        // GET: Leks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Naziv,Proizvodjac,Uputstvo")] Lek lek)
        {
            if (ModelState.IsValid)
            {
                db.Leks.Add(lek);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lek);
        }

        // GET: Leks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lek lek = db.Leks.Find(id);
            if (lek == null)
            {
                return HttpNotFound();
            }
            return View(lek);
        }

        // POST: Leks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Naziv,Proizvodjac,Uputstvo")] Lek lek)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lek).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lek);
        }

        // GET: Leks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lek lek = db.Leks.Find(id);
            if (lek == null)
            {
                return HttpNotFound();
            }
            return View(lek);
        }

        // POST: Leks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lek lek = db.Leks.Find(id);
            db.Leks.Remove(lek);
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
