using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using ClothingStore.DAL;
using ClothingStore.Models;

namespace ClothingStore.Controllers
{
    public class CartController : Controller
    {
        private CartContext db = new CartContext();

        // GET: Cart
        public ActionResult Index()
        {
            UserEntity currentUser = (UserEntity)Session["CurrentUser"];
            List<Cart> list = db.CartSet.ToList();
            List<Cart> filteredUserList = new List<Cart>();
            list.ForEach(item =>
            {
                if (item.UserName.Equals(currentUser.UserName))
                {
                    filteredUserList.Add(item);
                }
            });
            return View(filteredUserList);
        }

        // GET: Cart/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cart cart = db.CartSet.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        // GET: Cart/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AddToCart(int itemId, string itemName, string itemImageUrl, double itemPrice, String from)
        {

            UserEntity currentUser = (UserEntity)Session["CurrentUser"];
            Cart cart = new Cart();
            cart.itemId = itemId;
            cart.itemName = itemName;
            cart.itemImageUrl = itemImageUrl;
            cart.itemPrice = itemPrice;
            cart.UserName = currentUser.UserName;
            db.CartSet.Add(cart);
            db.SaveChanges();
            return RedirectToAction("Index", from);
        }


        // POST: Cart/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,UserName,itemId,itemName,itemImageUrl,itemPrice")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                db.CartSet.Add(cart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cart);
        }

        // GET: Cart/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cart cart = db.CartSet.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        // POST: Cart/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,UserName,itemId,itemName,itemImageUrl,itemPrice")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cart);
        }

        // GET: Cart/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cart cart = db.CartSet.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        public ActionResult ClearCart()
        {
            UserEntity currentUser = (UserEntity)Session["CurrentUser"];
            List<Cart> list = db.CartSet.ToList();
            list.ForEach(item =>
            {
                if (item.UserName.Equals(currentUser.UserName))
                {
                    db.CartSet.Remove(item);
                }
            });
            db.SaveChanges();
            return RedirectToAction("Index", "Sections");
        }

        // POST: Cart/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cart cart = db.CartSet.Find(id);
            db.CartSet.Remove(cart);
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
