using ClothingStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.DAL
{
    public class SectionInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SectionContext>
    {
        protected override void Seed(SectionContext context)
        {
            var sections = new List<Section>
            {
            new Section{Title="Hats",ImageUrl="https://i.ibb.co/cvpntL1/hats.png",Id=1,LinkUrl="shop/hats"},
            new Section{Title="Jackets",ImageUrl="https://i.ibb.co/px2tCc3/jackets.png",Id=2,LinkUrl="shop/jackets"},
            new Section{Title="Sneakers",ImageUrl="https://i.ibb.co/0jqHpnp/sneakers.png",Id=3,LinkUrl="shop/sneakers"},
            new Section{Title="Women",ImageUrl="https://i.ibb.co/GCCdy8t/womens.png",Id=4,LinkUrl="shop/women"},
            new Section{Title="Men",ImageUrl="https://i.ibb.co/R70vBrQ/men.png",Id=5,LinkUrl="shop/men"},
            };

            sections.ForEach(s => context.Sections.Add(s));
            context.SaveChanges();
        }
    }
}