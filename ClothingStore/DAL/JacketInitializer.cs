using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.DAL
{
    public class JacketInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<JacketContext>
    {
        protected override void Seed(JacketContext context)
        {
            var jackets = new List<Jackets>{
                new Jackets { id = 1, name = "Black Jean Shearling", imageUrl = "https://i.ibb.co/XzcwL5s/black-shearling.png", price = 125 },
                new Jackets { id = 2, name = "Blue Jean Jacket", imageUrl = "https://i.ibb.co/mJS6vz0/blue-jean-jacket.png", price = 118 },
                new Jackets { id = 3, name = "Grey Jean Jacket", imageUrl = "https://i.ibb.co/N71k1ML/grey-jean-jacket.png", price = 135 },
                new Jackets { id = 4, name = "Brown Shearling", imageUrl = "https://i.ibb.co/s96FpdP/brown-shearling.png", price = 125 },
                new Jackets { id = 5, name = "Tan Trench", imageUrl = "https://i.ibb.co/M6hHc3F/brown-trench.png", price = 218 },
             };

            jackets.ForEach(s => context.JacketsSet.Add(s));
            context.SaveChanges();
        }
    }
}