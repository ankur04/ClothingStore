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
    public class SneakersController : Controller
    {
        private SneakersContext db = new SneakersContext();

        // GET: Sneakers
        public ActionResult Index()
        {
            return View(db.SneakerSet.ToList());
        }

        // GET: Sneakers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sneakers sneakers = db.SneakerSet.Find(id);
            if (sneakers == null)
            {
                return HttpNotFound();
            }
            return View(sneakers);
        }

        // GET: Sneakers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sneakers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,imageUrl,price")] Sneakers sneakers)
        {
            if (ModelState.IsValid)
            {
                db.SneakerSet.Add(sneakers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sneakers);
        }

        // GET: Sneakers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sneakers sneakers = db.SneakerSet.Find(id);
            if (sneakers == null)
            {
                return HttpNotFound();
            }
            return View(sneakers);
        }

        // POST: Sneakers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,imageUrl,price")] Sneakers sneakers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sneakers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sneakers);
        }

        // GET: Sneakers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sneakers sneakers = db.SneakerSet.Find(id);
            if (sneakers == null)
            {
                return HttpNotFound();
            }
            return View(sneakers);
        }

        // POST: Sneakers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sneakers sneakers = db.SneakerSet.Find(id);
            db.SneakerSet.Remove(sneakers);
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
