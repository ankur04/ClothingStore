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
    public class MenController : Controller
    {
        private MenContext db = new MenContext();

        // GET: Men
        public ActionResult Index()
        {
            return View(db.MenSet.ToList());
        }

        // GET: Men/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Men men = db.MenSet.Find(id);
            if (men == null)
            {
                return HttpNotFound();
            }
            return View(men);
        }

        // GET: Men/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Men/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,name,imageUrl,price")] Men men)
        {
            if (ModelState.IsValid)
            {
                db.MenSet.Add(men);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(men);
        }

        // GET: Men/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Men men = db.MenSet.Find(id);
            if (men == null)
            {
                return HttpNotFound();
            }
            return View(men);
        }

        // POST: Men/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,name,imageUrl,price")] Men men)
        {
            if (ModelState.IsValid)
            {
                db.Entry(men).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(men);
        }

        // GET: Men/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Men men = db.MenSet.Find(id);
            if (men == null)
            {
                return HttpNotFound();
            }
            return View(men);
        }

        // POST: Men/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Men men = db.MenSet.Find(id);
            db.MenSet.Remove(men);
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
