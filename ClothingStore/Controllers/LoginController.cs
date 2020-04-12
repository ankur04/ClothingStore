using ClothingStore.DAL;
using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingStore.Controllers
{
    public class LoginController : Controller
    {

        private UserContext db = new UserContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "UserName, Password")] UserEntity user)
        {

            if (!String.IsNullOrEmpty(user.UserName) && !String.IsNullOrEmpty(user.Password))
            {
                UserEntity userEntity = db.Users.FirstOrDefault(u => u.UserName == user.UserName && u.Password == user.Password);
                if (userEntity != null)
                {
                    return RedirectToAction("Index", "Sections");
                }
            }

            return View();
        }

    }
}