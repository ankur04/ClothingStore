using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.DAL
{
    public class CartInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CartContext>
    {
        protected override void Seed(CartContext context)
        {
            UserEntity user = new UserEntity();
            user.UserName = "a1@gmail.com";
            user.Password = "a1";

            var item_id = 2;

            Item item = new Jackets { id = 20, name = "Black Jean Shearling", imageUrl = "https://i.ibb.co/XzcwL5s/black-shearling.png", price = 125 };
        
            var cart = new List<Cart> {
                new Cart {UserName = user.UserName, itemId = item_id, itemName = item.name, itemImageUrl = item.imageUrl, itemPrice = item.price }
             };

            cart.ForEach(s => context.CartSet.Add(s));
            context.SaveChanges();



        }
    }
}