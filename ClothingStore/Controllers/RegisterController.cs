using ClothingStore.DAL;
using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClothingStore.Controllers
{
    public class RegisterController : Controller


    {

        private UserContext db = new UserContext();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index([Bind(Include = "UserName, Password, ConfirmPassword")] User user)
        {
            
            if ( !String.IsNullOrEmpty(user.UserName) &&  !String.IsNullOrEmpty(user.Password) && user.Password.Equals(user.ConfirmPassword))
            {

                db.Users.Add(new UserEntity(user.UserName, user.Password));
                db.SaveChanges();
                UserEntity userEntity = new UserEntity();
                userEntity.UserName = user.UserName;
                userEntity.Password = user.Password;
                Session.Add("CurrentUser", userEntity);
                return RedirectToAction("Index","Sections");
            }
               
            return View();
        }

    }

}