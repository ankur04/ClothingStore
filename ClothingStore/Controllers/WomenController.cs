using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ClothingStore.DAL;
using ClothingStore.Models;

namespace ClothingStore.Controllers
{
    public class WomenController : Controller
    {
        private WomenContext db = new WomenContext();

        // GET: Women
        public ActionResult Index()
        {
            return View(db.WomenSet.ToList());
        }

        // GET: Women/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Women women = db.WomenSet.Find(id);
            if (women == null)
            {
                return HttpNotFound();
            }
            return View(women);
        }

        // GET: Women/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Women/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,imageUrl,price")] Women women)
        {
            if (ModelState.IsValid)
            {
                db.WomenSet.Add(women);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(women);
        }

        // GET: Women/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Women women = db.WomenSet.Find(id);
            if (women == null)
            {
                return HttpNotFound();
            }
            return View(women);
        }

        // POST: Women/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,imageUrl,price")] Women women)
        {
            if (ModelState.IsValid)
            {
                db.Entry(women).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(women);
        }

        // GET: Women/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Women women = db.WomenSet.Find(id);
            if (women == null)
            {
                return HttpNotFound();
            }
            return View(women);
        }

        // POST: Women/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Women women = db.WomenSet.Find(id);
            db.WomenSet.Remove(women);
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
