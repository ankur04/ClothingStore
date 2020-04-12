using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothingStore.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string imageUrl { get; set; }
        public double price { get; set; }

     
    }
}