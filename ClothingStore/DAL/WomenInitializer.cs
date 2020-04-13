using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.DAL
{
    public class WomenInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<WomenContext>
    {
        protected override void Seed(WomenContext context)
        {
            var women = new List<Women> {
            new Women { id= 63, name= "Blue Tanktop", imageUrl= "https://i.ibb.co/7CQVJNm/blue-tank.png", price= 25 },
            new Women { id= 64, name= "Floral Blouse", imageUrl= "https://i.ibb.co/4W2DGKm/floral-blouse.png", price= 20 },
            new Women { id= 65, name= "Floral Dress", imageUrl= "https://i.ibb.co/KV18Ysr/floral-skirt.png", price= 80 },
            new Women { id= 66, name= "Red Dots Dress", imageUrl= "https://i.ibb.co/N3BN1bh/red-polka-dot-dress.png", price= 80 },
            new Women { id= 67, name= "Striped Sweater", imageUrl= "https://i.ibb.co/KmSkMbH/striped-sweater.png", price= 45 },
            new Women { id= 68, name= "Yellow Track Suit", imageUrl= "https://i.ibb.co/v1cvwNf/yellow-track-suit.png", price= 135 },
            new Women { id= 69, name= "White Blouse", imageUrl= "https://i.ibb.co/qBcrsJg/white-vest.png", price= 20 }
        };

            women.ForEach(s => context.WomenSet.Add(s));
            context.SaveChanges();
        }
    }
}