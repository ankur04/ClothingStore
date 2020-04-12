using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.DAL
{
    public class MenInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MenContext>
    {
        protected override void Seed(MenContext context)
        {
            var men = new List<Men> {
            new Men { id= 30, name= "Camo Down Vest", imageUrl= "https://i.ibb.co/xJS0T3Y/camo-vest.png", price= 325 },
            new Men { id= 31, name= "Floral T-shirt", imageUrl= "https://i.ibb.co/qMQ75QZ/floral-shirt.png", price= 20 },
            new Men { id= 32, name= "Black & White Longsleeve", imageUrl= "https://i.ibb.co/55z32tw/long-sleeve.png", price= 25 },
            new Men { id= 33, name= "Pink T-shirt", imageUrl= "https://i.ibb.co/RvwnBL8/pink-shirt.png", price= 25 },
            new Men { id= 34, name= "Jean Long Sleeve", imageUrl= "https://i.ibb.co/VpW4x5t/roll-up-jean-shirt.png", price= 40 },
            new Men { id= 35, name= "Burgundy T-shirt", imageUrl= "https://i.ibb.co/mh3VM1f/polka-dot-shirt.png", price= 25 }
        };

            men.ForEach(s => context.MenSet.Add(s));
            context.SaveChanges();
        }
    }
}