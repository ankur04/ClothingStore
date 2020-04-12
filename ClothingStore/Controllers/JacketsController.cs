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
    public class JacketsController : Controller
    {
        private JacketContext db = new JacketContext();

        // GET: Jackets
        public ActionResult Index()
        {
            return View(db.JacketsSet.ToList());
        }

        // GET: Jackets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jackets jackets = db.JacketsSet.Find(id);
            if (jackets == null)
            {
                return HttpNotFound();
            }
            return View(jackets);
        }

        // GET: Jackets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Jackets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,imageUrl,price")] Jackets jackets)
        {
            if (ModelState.IsValid)
            {
                db.JacketsSet.Add(jackets);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jackets);
        }

        // GET: Jackets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jackets jackets = db.JacketsSet.Find(id);
            if (jackets == null)
            {
                return HttpNotFound();
            }
            return View(jackets);
        }

        // POST: Jackets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,imageUrl,price")] Jackets jackets)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jackets).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jackets);
        }

        // GET: Jackets/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jackets jackets = db.JacketsSet.Find(id);
            if (jackets == null)
            {
                return HttpNotFound();
            }
            return View(jackets);
        }

        // POST: Jackets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jackets jackets = db.JacketsSet.Find(id);
            db.JacketsSet.Remove(jackets);
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
