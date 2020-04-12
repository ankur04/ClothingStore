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
    public class HatsController : Controller
    {
        private HatContext db = new HatContext();

        // GET: Hat
        public ActionResult Index()
        {
            return View(db.HatsSet.ToList());
        }

        // GET: Hat/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hats hats = db.HatsSet.Find(id);
            if (hats == null)
            {
                return HttpNotFound();
            }
            return View(hats);
        }

        // GET: Hat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hat/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,imageUrl,price")] Hats hats)
        {
            if (ModelState.IsValid)
            {
                db.HatsSet.Add(hats);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hats);
        }

        // GET: Hat/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hats hats = db.HatsSet.Find(id);
            if (hats == null)
            {
                return HttpNotFound();
            }
            return View(hats);
        }

        // POST: Hat/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,imageUrl,price")] Hats hats)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hats).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hats);
        }

        // GET: Hat/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hats hats = db.HatsSet.Find(id);
            if (hats == null)
            {
                return HttpNotFound();
            }
            return View(hats);
        }

        // POST: Hat/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hats hats = db.HatsSet.Find(id);
            db.HatsSet.Remove(hats);
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
