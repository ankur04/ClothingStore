using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.DAL
{
    public class HatInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<HatContext>
    {
        protected override void Seed(HatContext context)
        {
            var hats = new List<Hats>{
                new Hats { id = 1, name = "BrownBrim", imageUrl = "https://i.ibb.co/ZYW3VTp/brown-brim.png", price = 25 },
	            new Hats { id = 2, name = "BlueBeanie", imageUrl = "https://i.ibb.co/ypkgK0X/blue-beanie.png", price = 18 },
	            new Hats { id = 3, name = "BrownCowboy", imageUrl = "https://i.ibb.co/QdJwgmp/brown-cowboy.png", price = 35 },
	            new Hats { id = 4, name = "GreyBrim", imageUrl = "https://i.ibb.co/RjBLWxB/grey-brim.png", price = 25 },
	            new Hats { id = 5, name = "GreenBeanie", imageUrl = "https://i.ibb.co/YTjW3vF/green-beanie.png", price = 18 },
	            new Hats { id = 6, name = "PalmTreeCap", imageUrl = "https://i.ibb.co/rKBDvJX/palm-tree-cap.png", price = 14 },
	            new Hats { id = 7, name = "RedBeanie", imageUrl = "https://i.ibb.co/bLB646Z/red-beanie.png", price = 18 },
	            new Hats { id = 8, name = "WolfCap", imageUrl = "https://i.ibb.co/1f2nWMM/wolf-cap.png", price = 14 },
	            new Hats { id = 9, name = "BlueSnapback", imageUrl = "https://i.ibb.co/X2VJP2W/blue-snapback.png", price = 16 }
             };

            hats.ForEach(s => context.HatsSet.Add(s));
            context.SaveChanges();
        }
    }
}